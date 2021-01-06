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
   public class DrivingLessonViewModel : BaseViewModel
    {
        private readonly APIService _instructor_categories_candidateService = new APIService("Instructors_Categories_Candidates");
        private readonly APIService _instructor_categoriesService = new APIService("Instructors_Categories");
        private readonly APIService _instructorsService = new APIService("Instructors");
        private readonly APIService _candidatesService = new APIService("Candidates");

        public DrivingLessonViewModel()
        {
            SubmitCommand = new Command(async () => { await Submit(); });
        }


        public ObservableCollection<Candidate> CandidatesList { get; set; } = new ObservableCollection<Candidate>();



        public ICommand SubmitCommand { get; set; }


        public async Task Init()
        {
            InstructorSearchRequest search_request1 = new InstructorSearchRequest();
            search_request1.Username = APIService.Username;
            var instructors = await _instructorsService.GetAll<List<Instructor>>(search_request1);
            var instructor = instructors[0];            // Returns logged in instructor

            InstructorCategorySearchRequest search_request2 = new InstructorCategorySearchRequest();
            search_request2.UserId = instructor.Id;
            var instructors_categories = await _instructor_categoriesService.GetAll<List<Instructor_Category>>(search_request2); // Returns all categories of logged in instructor

            InstructorCategoryCandidateSearchRequest search_request3 = new InstructorCategoryCandidateSearchRequest();
           
            search_request3.PolozenTeorijskiTest = true;
            search_request3.PolozenPrakticniTest = false;
            search_request3.Prijavljen = false;
            foreach (var instructor_category in instructors_categories)
            {
                search_request3.Instructor_CategoryId = instructor_category.Id;
                var instructors_categories_candidates = await _instructor_categories_candidateService.GetAll<List<Instructor_Category_Candidate>>(search_request3); // Returns all users of logged in instructors and all categories of that instructor
                foreach (var instructor_category_candidate in instructors_categories_candidates)
                {
                    var candidate = await _candidatesService.GetById<Candidate>(instructor_category_candidate.UserId);
                    CandidatesList.Add(candidate);
                }
            }   
        }


        async Task Submit()
        {
           
        }
    }
}
