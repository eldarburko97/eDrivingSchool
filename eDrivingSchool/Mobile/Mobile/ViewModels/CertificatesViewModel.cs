using eDrivingSchool.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.ViewModels
{
   public class CertificatesViewModel : BaseViewModel
    {
        private readonly APIService _certificateService = new APIService("Certificates");

        string _price = string.Empty;
        public string Price
        {
            get { return _price = "10.00 KM"; }
            set { SetProperty(ref _price, value); }
        }
        public ObservableCollection<Certificate> CertificateList { get; set; } = new ObservableCollection<Certificate>();

        public async Task Init()
        {
            var certificatesList = await _certificateService.GetAll<List<Certificate>>(null);

            foreach(var certificate in certificatesList)
            {
                CertificateList.Add(certificate);
            }
        }
    }
}
