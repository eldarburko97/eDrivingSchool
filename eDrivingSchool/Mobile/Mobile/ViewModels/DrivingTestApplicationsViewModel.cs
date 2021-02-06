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
        private readonly InstructorCategoryCandidateAPIService _instructor_categories_candidateService = new InstructorCategoryCandidateAPIService("Instructors_Categories_Candidates");
        private readonly APIService _instructorsService = new APIService("Instructors");
        private readonly APIService _instructor_categoriesService = new APIService("Instructors_Categories");
        private readonly APIService _candidatesService = new APIService("Candidates");
        private readonly APIService _categoriesService = new APIService("Categories");
        private readonly APIService _driving_test_applicationsService = new APIService("DrivingTestApplications");

        InstructorSearchRequest request = new InstructorSearchRequest();
        InstructorCategorySearchRequest request2 = new InstructorCategorySearchRequest();

        public ObservableCollection<Candidate> CandidatesList { get; set; } = new ObservableCollection<Candidate>();



        public async Task Init() // Displays list of candidates of logged in instructor for driving test applications
        {
            if(CandidatesList.Count > 0)
            {
                CandidatesList.Clear();
            }
            request.Username = APIService.Username;
            var instructors = await _instructorsService.GetAll<List<Instructor>>(request);
            var instructor = instructors[0];            // Returns logged in instructor


            request2.InstructorId = instructor.Id;
            var instructors_categories = await _instructor_categoriesService.GetAll<List<Instructor_Category>>(request2); // Returns all categories of logged in instructor

            InstructorCategoryCandidateSearchRequest request3 = new InstructorCategoryCandidateSearchRequest();
            request3.PolozenTeorijskiTest = true;
            request3.PolozenTestPrvePomoci = true;
            request3.PolozenPrakticniTest = false;
            request3.Prijavljen = false;
            foreach (var instructor_category in instructors_categories)
            {
                request3.InstructorId = instructor_category.InstructorId;
                request3.CategoryId = instructor_category.CategoryId;
                var instructors_categories_candidates = await _instructor_categories_candidateService.GetAll<List<Instructor_Category_Candidate>>(request3); // Returns all users of logged in instructors and all categories of that instructor
                foreach (var instructor_category_candidate in instructors_categories_candidates)
                {                    
                    var candidate = await _candidatesService.GetById<Candidate>(instructor_category_candidate.CandidateId);
                    candidate.candidate_category = candidate.candidate + " " + "(" + instructor_category_candidate.Instructor_Category.Category.Name + ")";
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
                request3.InstructorId = instructor_category.InstructorId;
                request3.CategoryId = instructor_category.CategoryId;
                foreach (var candidate in Candidates)
                {
                    request3.CandidateId = candidate.Id;
                    request3.PolozenTeorijskiTest = true;
                    request3.PolozenTestPrvePomoci = true;
                    request3.PolozenPrakticniTest = false;
                    request3.Prijavljen = false;
                    var instructors_categories_candidates = await _instructor_categories_candidateService.GetAll<List<Instructor_Category_Candidate>>(request3);
                    foreach (var instructor_category_candidate in instructors_categories_candidates)
                    {
                        insert_request.InstructorId = instructor_category_candidate.InstructorId;
                        insert_request.CategoryId = instructor_category_candidate.CategoryId;
                        insert_request.CandidateId = instructor_category_candidate.CandidateId;
                        insert_request.Date = DateTime.Now.Date;
                        insert_request.Passed = false;
                        insert_request.Active = true;
                        await _driving_test_applicationsService.Insert<DrivingTestApplications>(insert_request);
                        count++;
                        request4.PolozenTestPrvePomoci = instructor_category_candidate.PolozenTestPrvePomoci;
                        request4.PolozenTeorijskiTest = instructor_category_candidate.PolozenTeorijskiTest;
                        request4.PolozenPrakticniTest = instructor_category_candidate.PolozenPrakticniTest;
                        request4.Prijavljen = true;
                        request4.NumberOfLessons = instructor_category_candidate.NumberOfLessons;
                        request4.Paid = instructor_category_candidate.Paid;
                        await _instructor_categories_candidateService.Update<Instructor_Category_Candidate>(instructor_category_candidate.InstructorId,instructor_category_candidate.CategoryId,instructor_category_candidate.CandidateId, request4);
                    }
                }
            }
            await Application.Current.MainPage.DisplayAlert("", "You have successfully submitted " + count + " request", "OK");
        }
    }
}
