using eDrivingSchool.Model;
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
        public List<Candidate> candidates { get; set; } = new List<Candidate>();
        public TheoryTestApplicationsPage()
        {
            InitializeComponent();
            candidates.Add(new Candidate { FirstName = "Candidate1", LastName = "Candidate11" });
            candidates.Add(new Candidate { FirstName = "Candidate2", LastName = "Candidate22" });
            candidates.Add(new Candidate { FirstName = "Candidate3", LastName = "Candidate33" });
            candidates.Add(new Candidate { FirstName = "Candidate4", LastName = "Candidate44" });
            candidates.Add(new Candidate { FirstName = "Candidate5", LastName = "Candidate5" });
            BindingContext = this;
            list.ItemsSource = candidates;
        }
    }
}