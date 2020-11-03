using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.ViewModels
{
    public class ForumViewModel : BaseViewModel
    {
        string _topic = string.Empty;
        public string Topic
        {
            get { return _topic; }
            set { SetProperty(ref _topic, value); }
        }

        int _posts = 0;
        public int Posts
        {
            get { return _posts; }
            set { SetProperty(ref _posts, value); }
        }

        string _lastPost = string.Empty;
        public string LastPost
        {
            get { return _lastPost; }
            set { SetProperty(ref _lastPost, value); }
        }
    }
}
