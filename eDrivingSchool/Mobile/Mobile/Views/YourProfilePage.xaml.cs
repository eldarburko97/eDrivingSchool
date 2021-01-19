using eDrivingSchool.Model.Requests;
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
    public partial class YourProfilePage : TabbedPage
    {
        private readonly APIService _apiService = new APIService("Users");
        public YourProfilePage()
        {
            InitializeComponent();

            this.Children.Add(new PersonalDataPage());
            this.Children.Add(new SettingsPage());

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            UserSearchRequest request = new UserSearchRequest { Username = APIService.Username };
            var list = await _apiService.GetAll<List<eDrivingSchool.Model.User>>(request);
            var user = list[0];
            if (user.RoleId == 3)
            {
                this.Children.Add(new PaymentsPage());
            }
        }
    }
}