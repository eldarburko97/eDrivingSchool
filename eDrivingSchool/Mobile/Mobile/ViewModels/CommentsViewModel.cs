using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.ViewModels
{
    public class CommentsViewModel : BaseViewModel
    {
        private readonly APIService _commentService = new APIService("Comments");
        private readonly APIService _userService = new APIService("Users");
        public CommentSearchRequest request = new CommentSearchRequest();

        public ObservableCollection<Comment> CommentList { get; set; } = new ObservableCollection<Comment>();

        public async Task Init(int id)
        {
            request.TopicId = id;
            var list = await _commentService.GetAll<List<Comment>>(request);
            CommentList.Clear();
            foreach (var comment in list)
            {
                var user = await _userService.GetById<User>(comment.UserId);
                comment.User = user.FirstName + " " + user.LastName;
                comment.Image = user.Image;
                CommentList.Add(comment);
            }
        }
    }
}
