using eDrivingSchool.Model;
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
    public class SettingsViewModel : BaseViewModel
    {
        APIService _service = new APIService("Users");
        public SettingsViewModel()
        {
            ShowCommand = new Command(() =>
              {
                  EntryVisible = true;
              });

            HideCommand = new Command(() =>
              {
                  EntryVisible = false;
              });

            ChangePasswordCommand = new Command(async () =>

                  await ChangePassword()
              );

            UpdateCommand = new Command(async () => await Update());
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
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

        bool _entryVisible = false;
        public bool EntryVisible
        {
            get { return _entryVisible; }
            set { SetProperty(ref _entryVisible, value); }
        }

        public ICommand ShowCommand { get; set; }

        public ICommand HideCommand { get; set; }

        public ICommand ChangePasswordCommand { get; set; }

        public ICommand UpdateCommand { get; set; }

        public async Task Init()
        {
            UserSearchRequest request = new UserSearchRequest
            {
                Username = APIService.Username
            };
            var list = await _service.GetAll<List<eDrivingSchool.Model.User>>(request);
            foreach (var user in list)
            {
                Phone = user.Phone;
                Email = user.Email;
            }
        }

        async Task ChangePassword()
        {
            UserSearchRequest request = new UserSearchRequest
            {
                Username = APIService.Username
            };
            var list = await _service.GetAll<List<eDrivingSchool.Model.User>>(request);
            var id = list[0].Id;
            var user = list[0];
            UserInsertRequest request2 = new UserInsertRequest
            {
                Password = Password,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Email = user.Email,
                Address = user.Address,
                Birthdate = user.Birthdate,
                JMBG = user.JMBG,
                RoleId = user.RoleId,
            };
            var returned_user = await _service.Update<eDrivingSchool.Model.User>(id, request2);
            Application.Current.MainPage = new LoginPage();

            /*
            try
            {
                //  await _service.GetById<dynamic>(1);
                await _service.GetAll<dynamic>(null);
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {

            }*/
        }

        async Task Update()
        {
            UserSearchRequest request = new UserSearchRequest
            {
                Username = APIService.Username
            };
            var list = await _service.GetAll<List<eDrivingSchool.Model.User>>(request);
            var id = list[0].Id;
            var user = list[0];
            UserInsertRequest request2 = new UserInsertRequest
            {
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = Email,
                Phone = Phone,
                Address = user.Address,
                Birthdate = user.Birthdate,
                JMBG = user.JMBG,
                RoleId = user.RoleId,
            };

            var returned_user = await _service.Update<eDrivingSchool.Model.User>(id, request2);
            Application.Current.MainPage = new YourProfilePage();
        }
    }
}
