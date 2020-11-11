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
    public partial class ForumPage : ContentPage
    {
        private ForumViewModel model = null;
        /*
        public IList<Topic> datagrids { get; set; }*/
        public ForumPage()
        {
            InitializeComponent();
            BindingContext = model = new ForumViewModel();
            /*
            datagrids = new List<Topic>();
            
            datagrids.Add(new Topic() { Subject = "Pomoc pri izradi seminarskih iz KGR", Description="Pomoc pri izradi seminarskih iz KGR", User="Eldar Burko", Date="2 years ago", Count = 13, LastPost = "Eldar Burko" });
            datagrids.Add(new Topic() { Subject = "Facebook grupa za studente treće godine", Description = "Upitnik?", User = "Eldar Burko", Date = "2 years ago", Count = 13, LastPost = "Eldar Burko" });
            datagrids.Add(new Topic() { Subject = "My Topic", Description = "Pomoc pri izradi seminarskih iz KGR", User = "Eldar Burko", Date = "2 years ago", Count = 13, LastPost = "Eldar Burko" });
            datagrids.Add(new Topic() { Subject = "My Topic", Description = "Pomoc pri izradi seminarskih iz KGR", User = "Eldar Burko", Date = "2 years ago", Count = 13, LastPost = "Eldar Burko" });
            datagrids.Add(new Topic() { Subject = "My Topic", Description = "Pomoc pri izradi seminarskih iz KGR", User = "Eldar Burko", Date = "2 years ago", Count = 13, LastPost = "Eldar Burko" });
            datagrids.Add(new Topic() { Subject = "My Topic", Description = "Pomoc pri izradi seminarskih iz KGR", User = "Eldar Burko", Date = "2 years ago", Count = 13, LastPost = "Eldar Burko" });
            datagrids.Add(new Topic() { Subject = "My Topic", Description = "Pomoc pri izradi seminarskih iz KGR", User = "Eldar Burko", Date = "2 years ago", Count = 13, LastPost = "Eldar Burko" });
            BindingContext = this;*/
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewTopicPage());
        }
    }
}