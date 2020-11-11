using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model
{
    public class Topic
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string User { get; set; } //Firstname + lastname
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int Comments { get; set; }
        public string LastComment { get; set; }
    }
}
