using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
   public class TopicInsertRequest
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
