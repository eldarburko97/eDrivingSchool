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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void GoTo_LoginPage(object sender, EventArgs e)
        {
            var mainPage = new MainPage()
            {
                Master = new MenuPage(),
                Detail = new NavigationPage(new LoginPage())
            };
            Application.Current.MainPage = mainPage;
        }
    }
}