using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mobile.ViewModels
{
    public class NewCommentViewModel : BaseViewModel
    {
        private readonly APIService _commentService = new APIService("Comments");
        private readonly APIService _userService = new APIService("Users");
        public UserSearchRequest _searchRequest = new UserSearchRequest();
        public CommentInsertRequest _commentRequest = new CommentInsertRequest();
        private int _id;
        public NewCommentViewModel()
        {

        }

        public NewCommentViewModel(int id)
        {
            _id = id;
            PostNewCommentCommand = new Command(async () =>
            {
                await Post(_id);
            });
        }

        string _message = string.Empty;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ICommand PostNewCommentCommand { get; set; }

        async Task Post(int Id) //TopicId
        {
            try
            {
                _searchRequest.Username = APIService.Username;
                var list = await _userService.GetAll<List<eDrivingSchool.Model.User>>(_searchRequest);
                var User = list[0];
                _commentRequest.UserId = User.Id;
                _commentRequest.TopicId = Id;
                _commentRequest.Message = Message;
                await _commentService.Insert<Comment>(_commentRequest);
                await Application.Current.MainPage.DisplayAlert("", "You have successfully posted new comment", "OK");
                Application.Current.MainPage = new CommentsPage(Id);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
