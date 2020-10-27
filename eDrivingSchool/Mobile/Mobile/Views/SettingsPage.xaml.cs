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
    public partial class SettingsPage : ContentPage
    {
        SettingsViewModel model = null;
        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = model = new SettingsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
           await model.Init();
        }
    }
}