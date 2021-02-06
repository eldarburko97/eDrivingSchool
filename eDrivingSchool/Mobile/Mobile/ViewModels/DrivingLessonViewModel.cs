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
        private readonly InstructorCategoryCandidateAPIService _instructor_categories_candidateService = new InstructorCategoryCandidateAPIService("Instructors_Categories_Candidates");
        private readonly APIService _instructor_categoriesService = new APIService("Instructors_Categories");
        private readonly APIService _instructorsService = new APIService("Instructors");
        private readonly APIService _candidatesService = new APIService("Candidates");
        private readonly APIService _vehiclesService = new APIService("Vehicles");
        private readonly APIService _drivingLessonsService = new APIService("DrivingLessons");
        private readonly APIService categoryService = new APIService("Categories");

        InstructorSearchRequest search_request1 = new InstructorSearchRequest();

        public DrivingLessonViewModel()
        {
            SubmitCommand = new Command(async () => { await Submit(); });
        }

        float _mileage = 0;
        public float Mileage
        {
            get { return _mileage; }
            set { SetProperty(ref _mileage, value); }
        }

        float _averageFuelConsumption = 0;
        public float AverageFuelConsumption
        {
            get { return _averageFuelConsumption; }
            set { SetProperty(ref _averageFuelConsumption, value); }
        }

        string _damage = string.Empty;
        public string Damage
        {
            get { return _damage; }
            set { SetProperty(ref _damage, value); }
        }

        DateTime _date = DateTime.Now;
        public DateTime Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }


        public ObservableCollection<Candidate> CandidatesList { get; set; } = new ObservableCollection<Candidate>();
        public ObservableCollection<Vehicle> VehiclesList { get; set; } = new ObservableCollection<Vehicle>();

        Candidate _selectedCandidate = null;
        public Candidate SelectedCandidate
        {
            get { return _selectedCandidate; }
            set
            {
                SetProperty(ref _selectedCandidate, value);
            }
        }

        Vehicle _selectedVehicle = null;
        public Vehicle SelectedVehicle
        {
            get { return _selectedVehicle; }
            set
            {
                SetProperty(ref _selectedVehicle, value);
            }
        }



        public ICommand SubmitCommand { get; set; }


        public async Task Init()
        {
           
            search_request1.Username = APIService.Username;
            var instructors = await _instructorsService.GetAll<List<Instructor>>(search_request1);
            var instructor = instructors[0];            // Returns logged in instructor

            InstructorCategorySearchRequest search_request2 = new InstructorCategorySearchRequest();
            search_request2.InstructorId = instructor.Id;
            var instructors_categories = await _instructor_categoriesService.GetAll<List<Instructor_Category>>(search_request2); // Returns all categories of logged in instructor

            InstructorCategoryCandidateSearchRequest search_request3 = new InstructorCategoryCandidateSearchRequest();

            search_request3.PolozenTeorijskiTest = true;
            search_request3.PolozenTestPrvePomoci = true;
            search_request3.PolozenPrakticniTest = false;
            search_request3.Prijavljen = false;
            search_request3.InstructorId = instructor.Id;
            foreach (var instructor_category in instructors_categories)
            {
                //search_request3.Instructor_CategoryId = instructor_category.Id;
                search_request3.CategoryId = instructor_category.CategoryId;
                var instructors_categories_candidates = await _instructor_categories_candidateService.GetAll<List<Instructor_Category_Candidate>>(search_request3); // Returns all users of logged in instructors and all categories of that instructor
                foreach (var instructor_category_candidate in instructors_categories_candidates)
                {
                    var candidate = await _candidatesService.GetById<Candidate>(instructor_category_candidate.CandidateId);
                    candidate.category = instructor_category_candidate.Instructor_Category.Category.Name;
                    candidate.candidate_category = candidate.candidate + " " + "(" + candidate.category + ")";
                    CandidatesList.Add(candidate);
                }
            }

            VehicleSearchRequest vehicle_search_request = new VehicleSearchRequest();
            var vehicles = await _vehiclesService.GetAll<List<Vehicle>>(null);
            foreach (var vehicle in vehicles)
            {
                vehicle.vehicle = vehicle.Model.Name + " " + "(" + vehicle.RegistrationNumber + ")";
                VehiclesList.Add(vehicle);
            }
        }


        async Task Submit()
        {
            DrivingLessonInsertRequest driving_lesson_insert_request = new DrivingLessonInsertRequest();
            CategorySearchRequest categorySearchRequest = new CategorySearchRequest
            {
                Name = SelectedCandidate.category
            };
            var categories = await categoryService.GetAll<List<Category>>(categorySearchRequest);
            var category = categories[0]; // Returns category of candidate

            search_request1.Username = APIService.Username;
            var instructors = await _instructorsService.GetAll<List<Instructor>>(search_request1);
            var instructor = instructors[0];   // Returns logged in instructor

            
            
            driving_lesson_insert_request.InstructorId = instructor.Id;
            driving_lesson_insert_request.CategoryId = category.Id;
            driving_lesson_insert_request.CandidateId = SelectedCandidate.Id;
            driving_lesson_insert_request.VehicleId = SelectedVehicle.Id;
            driving_lesson_insert_request.Mileage = Mileage;
            driving_lesson_insert_request.AverageFuelConsumption = AverageFuelConsumption;
            driving_lesson_insert_request.Damage = Damage;
            driving_lesson_insert_request.Date = Date;

            await _drivingLessonsService.Insert<DrivingLesson>(driving_lesson_insert_request);
            await Application.Current.MainPage.DisplayAlert("", "You have successfully added a lesson", "OK");
        }
    }
}
