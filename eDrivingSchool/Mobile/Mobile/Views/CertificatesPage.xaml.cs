using eDrivingSchool.Model;
using Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CertificatesPage : ContentPage
    {
        List<string> list;
        List<Certificate> certificates = null;
        private CertificatesViewModel model = null;
        public CertificatesPage()
        {
            InitializeComponent();
            BindingContext = model = new CertificatesViewModel();
            list = new List<string>();
            list.Add("item1");
            list.Add("item2");
            list.Add("item3");
            //   List.ItemsSource = list;
            certificates = new List<Certificate>();
            certificates.Add(new Certificate { Svrha = "Uvjerenje o statusu studenta", Datum = "15.06.2020", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Uvjerenje o položenim ispitima sa prosječnom ocjenom", Datum = "16.12.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            certificates.Add(new Certificate { Svrha = "Ljekarsko uvjernje o zdravstvenom stanju", Datum = "23.01.2019", Status = "Izdata" });
            // Certificates.ItemsSource = certificates;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}