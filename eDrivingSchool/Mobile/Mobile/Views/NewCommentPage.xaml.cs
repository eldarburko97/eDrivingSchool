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
    public partial class NewCommentPage : ContentPage
    {
        private NewCommentViewModel model = null;
        private int _id;
        public NewCommentPage()
        {
            InitializeComponent();
        }

        public NewCommentPage(int id)
        {
            InitializeComponent();
            _id = id;
            BindingContext = model = new NewCommentViewModel(_id);
        }
    }
}