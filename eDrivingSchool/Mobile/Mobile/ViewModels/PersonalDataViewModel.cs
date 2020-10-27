using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.ViewModels
{
   public class PersonalDataViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Users");

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
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

        string _address = string.Empty;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        string _jmbg = string.Empty;
        public string JMBG
        {
            get { return _jmbg; }
            set { SetProperty(ref _jmbg, value); }
        }

        string _birthdate = string.Empty;
        public string Birthdate
        {
            get { return _birthdate; }
            set { SetProperty(ref _birthdate, value); }
        }

        public async Task Init()
        {
            UserSearchRequest request = new UserSearchRequest
            {
                Username = APIService.Username
            };
            var user = await _service.GetAll<List<eDrivingSchool.Model.User>>(request);
            foreach(var item in user)
            {
                Username = item.Username;
                FirstName = item.FirstName;
                LastName = item.LastName;
                Address = item.Address;
                JMBG = item.JMBG;
                Birthdate = item.Birthdate.ToString("dd MMMM yyyy");
            }
        }
    }
}
