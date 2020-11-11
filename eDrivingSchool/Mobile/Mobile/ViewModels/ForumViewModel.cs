using eDrivingSchool.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mobile.ViewModels
{
    public class ForumViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Topics");
        private readonly APIService _userService = new APIService("Users");
        private readonly APIService _commentService = new APIService("Comments");
        public ForumViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Topic> TopicList { get; set; } = new ObservableCollection<Topic>();
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _service.GetAll<List<Topic>>(null);
            TopicList.Clear();
            foreach (var topic in list)
            {
                var user = await _userService.GetById<User>(topic.UserId);
                topic.User = user.FirstName + user.LastName; //User that posted topic
                var _commentList = await _commentService.GetAll<List<Comment>>(topic.Id);
                topic.Comments = _commentList.Count; // Number of comments
                var _lastComment = _commentList[_commentList.Count - 1]; // Last comment of topic
                var user_lastComment = await _userService.GetById<User>(_lastComment.UserId);
                topic.LastComment = user_lastComment.FirstName + " " + user_lastComment.LastName;
                TopicList.Add(topic);
            }
        }
    }
}
