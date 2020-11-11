using eDrivingSchool.Model.Requests;
using Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mobile.ViewModels
{
   public class RegisterViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Users");
        public UserInsertRequest candidate = new UserInsertRequest();
        public RegisterViewModel()
        {
            RegisterCommand = new Command(async () => await Register());
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _passwordConfirm = string.Empty;
        public string PasswordConfirm
        {
            get { return _passwordConfirm; }
            set { SetProperty(ref _passwordConfirm, value); }
        }

        string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }
        string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        string _phone = string.Empty;
        public string Phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _address = string.Empty;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        DateTime _birthdate;
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { SetProperty(ref _birthdate, value); }
        }

        string _jmbg = string.Empty;
        public string JMBG
        {
            get { return _jmbg; }
            set { SetProperty(ref _jmbg, value); }
        }
        public ICommand RegisterCommand { get; set; }

        async Task Register()
        {
            // IsBusy = true;
            // APIService.Username = Username;
            // APIService.Password = Password;

            try
            {
                candidate.FirstName = FirstName;
                candidate.LastName = LastName;
                candidate.Username = Username;
                candidate.Password = Password;
                candidate.PasswordConfirm = PasswordConfirm;
                candidate.Phone = Phone;
                candidate.Email = Email;
                candidate.Address = Address;
                candidate.JMBG = JMBG;
                candidate.Birthdate = Birthdate;
                candidate.DrivingSchoolId = 1;
                candidate.RoleId = 3;
                await _service.Register<dynamic>(candidate);
                Application.Current.MainPage = new LoginPage();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
