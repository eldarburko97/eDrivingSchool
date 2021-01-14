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
    public partial class DrivingTestApplicationsPage : ContentPage
    {
        private DrivingTestApplicationsViewModel model = null;
        public DrivingTestApplicationsPage()
        {
            InitializeComponent();
            BindingContext = model = new DrivingTestApplicationsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}