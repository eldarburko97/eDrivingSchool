using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using Mobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mobile.ViewModels
{
    public class CertificatesViewModel : BaseViewModel
    {
        private readonly APIService _certificateService = new APIService("Certificates");
        private readonly APIService _userService = new APIService("Users");
        private readonly APIService _certificate_requestService = new APIService("Certificate_Requests");
        public UserSearchRequest user_searchRequest = new UserSearchRequest();
        public Certificate_RequestInsert certificate_requestInsert = new Certificate_RequestInsert();
        public Certificate_RequestSearch certificate_requestSearch = new Certificate_RequestSearch();

        public CertificatesViewModel()
        {
            SubmitCommand = new Command(async () => { await Submit(); });
            CancelCommand = new Command(async (certificate_request) => { await Cancel(certificate_request); });
        }

        string _purpose = string.Empty;
        public string Purpose
        {
            get { return _purpose; }
            set { SetProperty(ref _purpose, value); }
        }

        decimal _price = 0.00m;
        public decimal Price
        {
            get { return _price; }
            set { SetProperty(ref _price, value); }
        }
        public ObservableCollection<Certificate> CertificateList { get; set; } = new ObservableCollection<Certificate>();
        public ObservableCollection<Certificate_Request> Certificate_Requests_List { get; set; } = new ObservableCollection<Certificate_Request>();
        Certificate _selectedCertificate = null;
        public Certificate SelectedCertificate
        {
            get { return _selectedCertificate; }
            set
            {
                SetProperty(ref _selectedCertificate, value);
                if (value != null)
                {
                    Price = SelectedCertificate.Price;
                }
            }
        }

        string _purpose2 = string.Empty;
        public string Purpose2
        {
            get { return _purpose2; }
            set { SetProperty(ref _purpose2, value); }
        }

        string _details = string.Empty;
        public string Details
        {
            get { return _details; }
            set { SetProperty(ref _details, value); }
        }

        Certificate_Request _selectedCertificateRequest = null;
        public Certificate_Request SelectedCertificate_Request
        {
            get { return _selectedCertificateRequest; }
            set
            {
                SetProperty(ref _selectedCertificateRequest, value);
                if (value != null)
                {
                    Details = SelectedCertificate_Request.Purpose;
                    Purpose2 = "Purpose:";
                }
            }
        }

       

        public ICommand SubmitCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public async Task Init()
        {
            var certificatesList = await _certificateService.GetAll<List<Certificate>>(null);

            foreach (var certificate in certificatesList)
            {
                CertificateList.Add(certificate);
            }
        }

        async Task Submit()
        {
            user_searchRequest.Username = APIService.Username;
            var users_list = await _userService.GetAll<List<User>>(user_searchRequest);
            var user = users_list[0];
            certificate_requestInsert.UserId = user.Id;
            certificate_requestInsert.CertificateId = SelectedCertificate.Id;
            certificate_requestInsert.Purpose = Purpose;
            certificate_requestInsert.Date = DateTime.Now;
            certificate_requestInsert.Status = "On processing";
            await _certificate_requestService.Insert<Certificate_Request>(certificate_requestInsert);
            await Application.Current.MainPage.DisplayAlert("", "You have successfully submitted your request", "OK");
            Application.Current.MainPage = new CertificatesPage();
        }

        public async Task ShowCertificateRequests()
        {
            user_searchRequest.Username = APIService.Username;
            var users_list = await _userService.GetAll<List<User>>(user_searchRequest);
            var user = users_list[0];
            certificate_requestSearch.UserId = user.Id;
            var certificate_requests = await _certificate_requestService.GetAll<List<Certificate_Request>>(certificate_requestSearch);

            foreach (var certificate_request in certificate_requests)
            {
                Certificate_Requests_List.Add(certificate_request);
            }
        }

        async Task Cancel(object certificate_request)
        {
            var item = certificate_request as Certificate_Request;
            await _certificate_requestService.Delete<Certificate_Request>(item.Id);
            await Application.Current.MainPage.DisplayAlert("", "You have successfully cancelled your request", "OK");
            Application.Current.MainPage = new CertificatesPage();
        }
    }
}
