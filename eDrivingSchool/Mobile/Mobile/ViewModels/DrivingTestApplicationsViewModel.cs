using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.ViewModels
{
    public class DrivingTestApplicationsViewModel : BaseViewModel
    {
        private readonly APIService _instructor_categories_candidateService = new APIService("Instructors_Categories_Candidates");
        private readonly APIService _instructorsService = new APIService("Instructors");
        private readonly APIService _instructor_categoriesService = new APIService("Instructors_Categories");
        private readonly APIService _candidatesService = new APIService("Candidates");

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
            request3.PolozenPrakticniTest = false;
            request3.Prijavljen = false;
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
