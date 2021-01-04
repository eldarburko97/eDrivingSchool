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
    public partial class TheoryTestApplicationsPage : ContentPage
    {
        //  public List<Candidate> candidates { get; set; } = new List<Candidate>();
        private TheoryTestApplicationsViewModel model = null;
        public List<Candidate> candidates { get; set; } = null;
       // public List<Candidate> candidates { get; set; } = new List<Candidate>();
        public TheoryTestApplicationsPage()
        {
            InitializeComponent();
            BindingContext = model = new TheoryTestApplicationsViewModel();
            candidates = new List<Candidate>();
            /*
            candidates.Add(new Candidate { FirstName = "Candidate1", LastName = "Candidate11" });
            candidates.Add(new Candidate { FirstName = "Candidate2", LastName = "Candidate22" });
            candidates.Add(new Candidate { FirstName = "Candidate3", LastName = "Candidate33" });
            candidates.Add(new Candidate { FirstName = "Candidate4", LastName = "Candidate44" });
            candidates.Add(new Candidate { FirstName = "Candidate5", LastName = "Candidate5" });
            BindingContext = this;
            list.ItemsSource = candidates;*/
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void AwesomeCheckbox_IsCheckedChanged(object sender, TappedEventArgs e)
        {
            var checkbox = sender as IntelliAbb.Xamarin.Controls.Checkbox;
            var candidate = checkbox.BindingContext as Candidate;
            if (candidate.isChecked)
            {
                candidates.Add(candidate);
            }
            else
            {
                candidates.Remove(candidate);
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.Submit(candidates);
        }
    }
}