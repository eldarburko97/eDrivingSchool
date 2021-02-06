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
    public class NewTopicViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Topics");
        private readonly APIService _userService = new APIService("Users");
        private readonly APIService _commentService = new APIService("Comments");
        public TopicInsertRequest request = new TopicInsertRequest();
        public UserSearchRequest request2 = new UserSearchRequest();
        public CommentInsertRequest _commentRequest = new CommentInsertRequest();
        public NewTopicViewModel()
        {
            PostNewTopicCommand = new Command(async () =>
             {
                 await Post();
             });
        }
        string _subject = string.Empty;
        public string Subject
        {
            get { return _subject; }
            set { SetProperty(ref _subject, value); }
        }

        string _description = string.Empty;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        string _message = string.Empty;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        DateTime _date = DateTime.Now;
        public DateTime Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

        public ICommand PostNewTopicCommand { get; set; }

        async Task Post()
        {
            try
            {
                request.Subject = Subject;
                request.Description = Description;
                request.Message = Message;
                request.Date = Date;

                request2.Username = APIService.Username;
                var list = await _userService.GetAll<List<eDrivingSchool.Model.User>>(request2);
                var User = list[0];
                request.UserId = User.Id;
                var topic = await _service.Insert<Topic>(request);

                _commentRequest.TopicId = topic.Id;
                _commentRequest.UserId = User.Id;
                _commentRequest.Message = Message;
                await _commentService.Insert<Comment>(_commentRequest);
                await Application.Current.MainPage.DisplayAlert("", "You have successfully posted new topic", "OK");
                //  Application.Current.MainPage = new ForumPage(); 
                //await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
