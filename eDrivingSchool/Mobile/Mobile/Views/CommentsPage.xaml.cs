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
    public partial class CommentsPage : ContentPage
    {
        private CommentsViewModel model = null;
        private int _id;
        public CommentsPage()
        {
            InitializeComponent();
        }

        public CommentsPage(int Id) // TopicId
        {
            InitializeComponent();
            _id = Id;
            BindingContext = model = new CommentsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init(_id);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewCommentPage(_id));
        }
    }
}