using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile.ViewModels
{
    public class DrivingTestApplicationsViewModel : BaseViewModel
    {
        private readonly APIService _instructor_categories_candidateService = new APIService("Instructors_Categories_Candidates");
        private readonly APIService _instructorsService = new APIService("Instructors");
        private readonly APIService _instructor_categoriesService = new APIService("Instructors_Categories");
        private readonly APIService _candidatesService = new APIService("Candidates");
        private readonly APIService _categoriesService = new APIService("Categories");
        private readonly APIService _driving_test_applicationsService = new APIService("DrivingTestApplications");

        InstructorSearchRequest request = new InstructorSearchRequest();
        InstructorCategorySearchRequest request2 = new InstructorCategorySearchRequest();

        public ObservableCollection<Candidate> CandidatesList { get; set; } = new ObservableCollection<Candidate>();



        public async Task Init()
        {
            if(CandidatesList.Count > 0)
            {
                CandidatesList.Clear();
            }
            request.Username = APIService.Username;
            var instructors = await _instructorsService.GetAll<List<Instructor>>(request);
            var instructor = instructors[0];            // Returns logged in instructor


            request2.UserId = instructor.Id;
            var instructors_categories = await _instructor_categoriesService.GetAll<List<Instructor_Category>>(request2); // Returns all categories of logged in instructor

            InstructorCategoryCandidateSearchRequest request3 = new InstructorCategoryCandidateSearchRequest();
            request3.PolozenTeorijskiTest = true;
            request3.PolozenTestPrvePomoci = true;
            request3.PolozenPrakticniTest = false;
            request3.Prijavljen = false;
            foreach (var instructor_category in instructors_categories)
            {
                request3.Instructor_CategoryId = instructor_category.Id;
                var instructors_categories_candidates = await _instructor_categories_candidateService.GetAll<List<Instructor_Category_Candidate>>(request3); // Returns all users of logged in instructors and all categories of that instructor
                foreach (var instructor_category_candidate in instructors_categories_candidates)
                {
                    int category_id = instructor_category_candidate.Instructor_Category.CategoryId;
                    var category = await _categoriesService.GetById<Category>(category_id);
                    var candidate = await _candidatesService.GetById<Candidate>(instructor_category_candidate.UserId);
                    candidate.candidate_category = candidate.FirstName + " " + candidate.LastName + " " + "(" + category.Name + ")";
                    CandidatesList.Add(candidate);
                }
            }
        }
        public async Task Submit(object candidates)
        {
            var Candidates = candidates as List<Candidate>;
            DrivingTestApplicationsInsertRequest insert_request = new DrivingTestApplicationsInsertRequest();



            var instructors_categories = await _instructor_categoriesService.GetAll<List<Instructor_Category>>(request2);
            InstructorCategoryCandidateSearchRequest request3 = new InstructorCategoryCandidateSearchRequest();
            InstructorCategoryCandidateInsertRequest request4 = new InstructorCategoryCandidateInsertRequest();
            int count = 0;
            foreach (var instructor_category in instructors_categories)
            {
                request3.Instructor_CategoryId = instructor_category.Id;
                foreach (var candidate in Candidates)
                {
                    request3.UserId = candidate.Id;
                    request3.PolozenTeorijskiTest = true;
                    request3.PolozenPrakticniTest = false;
                    request3.Prijavljen = false;
                    var instructors_categories_candidates = await _instructor_categories_candidateService.GetAll<List<Instructor_Category_Candidate>>(request3);
                    foreach (var instructor_category_candidate in instructors_categories_candidates)
                    {
                        insert_request.Instructor_Category_CandidateId = instructor_category_candidate.Id;
                        insert_request.Date = DateTime.Now;
                        insert_request.Status = Status.Inactive;
                        await _driving_test_applicationsService.Insert<DrivingTestApplications>(insert_request);
                        count++;
                        request4.Instructor_CategoryId = instructor_category_candidate.Instructor_CategoryId;
                        request4.UserId = instructor_category_candidate.UserId;
                        request4.PolozenTestPrvePomoci = instructor_category_candidate.PolozenTestPrvePomoci;
                        request4.PolozenTeorijskiTest = instructor_category_candidate.PolozenTeorijskiTest;
                        request4.PolozenPrakticniTest = instructor_category_candidate.PolozenPrakticniTest;
                        request4.Prijavljen = true;
                        request4.NumberOfLessons = instructor_category_candidate.NumberOfLessons;
                        request4.Paid = instructor_category_candidate.Paid;
                        await _instructor_categories_candidateService.Update<Instructor_Category_Candidate>(instructor_category_candidate.Id, request4);
                    }
                }
            }
            await Application.Current.MainPage.DisplayAlert("", "You have successfully submitted " + count + " request", "OK");
        }
    }
}
