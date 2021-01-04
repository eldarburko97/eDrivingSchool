using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.ViewModels
{
    public class TheoryTestApplicationsViewModel
    {
        private readonly APIService _theoryTestApplicationsService = new APIService("TheoryTestApplications");
        private readonly APIService _instructor_categoriesService = new APIService("Instructors_Categories");
        private readonly APIService _instructorsService = new APIService("Instructors");
        private readonly APIService _instructor_categories_candidateService = new APIService("Instructors_Categories_Candidates");
        private readonly APIService _candidatesService = new APIService("Candidates");
        public TheoryTestApplicationsViewModel()
        {

        }



        public ObservableCollection<Candidate> CandidatesList { get; set; } = new ObservableCollection<Candidate>();


        public async Task Init()
        {
            InstructorSearchRequest request = new InstructorSearchRequest();
            request.Username = APIService.Username;
            var instructors = await _instructorsService.GetAll<List<Instructor>>(request);
            var instructor = instructors[0];            // Returns logged in instructor

            InstructorCategorySearchRequest request2 = new InstructorCategorySearchRequest();
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
    }
}
