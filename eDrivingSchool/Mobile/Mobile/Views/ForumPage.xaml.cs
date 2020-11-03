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
        public IList<Post> datagrids { get; set; }
        public ForumPage()
        {
            InitializeComponent();
            datagrids = new List<Post>();
            datagrids.Add(new Post() { Topic = "My Topic", Count = 13, CreatedBy = "Eldar Burko" });
            datagrids.Add(new Post() { Topic = "Second Topic", Count = 12, CreatedBy = "Larisa Burko" });
            datagrids.Add(new Post() { Topic = "Second Topic", Count = 12, CreatedBy = "Larisa Burko" });
            datagrids.Add(new Post() { Topic = "Second Topic", Count = 12, CreatedBy = "Larisa Burko" });
            datagrids.Add(new Post() { Topic = "Second Topic", Count = 12, CreatedBy = "Larisa Burko" });
            datagrids.Add(new Post() { Topic = "Second Topic", Count = 12, CreatedBy = "Larisa Burko" });
            datagrids.Add(new Post() { Topic = "Second Topic", Count = 12, CreatedBy = "Larisa Burko" });
            datagrids.Add(new Post() { Topic = "Second Topic", Count = 12, CreatedBy = "Larisa Burko" });
            datagrids.Add(new Post() { Topic = "Second Topic", Count = 12, CreatedBy = "Larisa Burko" });
            datagrids.Add(new Post() { Topic = "Second Topic", Count = 12, CreatedBy = "Larisa Burko" });
            datagrids.Add(new Post() { Topic = "Second Topic", Count = 12, CreatedBy = "Larisa Burko" });
            BindingContext = this;
        }
    }
}