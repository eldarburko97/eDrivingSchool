using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mobile.ViewModels
{
    public class TheoryTestApplicationsViewModel
    {
        private readonly APIService _theoryTestApplicationsService = new APIService("TheoryTestApplications");
        private readonly APIService _instructor_categoriesService = new APIService("Instructors_Categories");
        private readonly APIService _instructorsService = new APIService("Instructors");
        private readonly APIService _instructor_categories_candidateService = new APIService("Instructors_Categories_Candidates");
        private readonly APIService _candidatesService = new APIService("Candidates");


        InstructorSearchRequest request = new InstructorSearchRequest();
        InstructorCategorySearchRequest request2 = new InstructorCategorySearchRequest();
        public TheoryTestApplicationsViewModel()
        {
            // SubmitCommand = new Command(async (candidates) => { await Submit(candidates); });
        }



        public ObservableCollection<Candidate> CandidatesList { get; set; } = new ObservableCollection<Candidate>();

        // public ICommand SubmitCommand { get; set; }

        public async Task Init()
        {

            request.Username = APIService.Username;
            var instructors = await _instructorsService.GetAll<List<Instructor>>(request);
            var instructor = instructors[0];            // Returns logged in instructor


            request2.UserId = instructor.Id;
            var instructors_categories = await _instructor_categoriesService.GetAll<List<Instructor_Category>>(request2); // Returns all categories of logged in instructor

            InstructorCategoryCandidateSearchRequest request3 = new InstructorCategoryCandidateSearchRequest();
            foreach (var instructor_category in instructors_categories)
            {
                request3.Instructor_CategoryId = instructor_category.Id;
                var instructors_categories_candidates = await _instructor_categories_candidateService.GetAll<List<Instructor_Category_Candidate>>(request3); // Returns all users of logged in instructors and all categories of that instructor
                foreach (var instructor_category_candidate in instructors_categories_candidates)
                {
                    var candidate = await _candidatesService.GetById<Candidate>(instructor_category_candidate.UserId);
                    CandidatesList.Add(candidate);
                }
            }
        }

        public async Task Submit(object candidates)
        {
            var Candidates = candidates as List<Candidate>;
            TheoryTestApplicationsInsertRequest insert_request = new TheoryTestApplicationsInsertRequest();



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
                    var instructors_categories_candidates = await _instructor_categories_candidateService.GetAll<List<Instructor_Category_Candidate>>(request3);
                    foreach (var instructor_category_candidate in instructors_categories_candidates)
                    {
                        insert_request.Instructor_Category_CandidateId = instructor_category_candidate.Id;
                        insert_request.Date = DateTime.Now;
                        insert_request.FirstAid = true;
                        insert_request.Status = Status.Active;
                        await _theoryTestApplicationsService.Insert<TheoryTestApplications>(insert_request);
                        count++;
                        request4.Prijavljen = true;
                        await _instructor_categories_candidateService.Update<Instructor_Category_Candidate>(instructor_category_candidate.Id, request4);
                    }
                }
            }
            await Application.Current.MainPage.DisplayAlert("", "You have successfully submitted " + count + " request", "OK");
        }
    }
}
