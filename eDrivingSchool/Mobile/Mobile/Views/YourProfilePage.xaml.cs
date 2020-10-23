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
        public YourProfilePage()
        {
            InitializeComponent();
            this.Children.Add(new PersonalDataPage());
            this.Children.Add(new SettingsPage());
            this.Children.Add(new PaymentsPage());
        }
    }
}