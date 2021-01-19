using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class Comment
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Message { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
    }
}
