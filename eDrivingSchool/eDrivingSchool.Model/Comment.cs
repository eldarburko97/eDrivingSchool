using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
   public class Comment
    {
        public int TopicId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
    }
}
