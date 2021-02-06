using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class PaymentInsertRequest
    {

        //   public int UserId { get; set; }
        //    public int Instructor_Category_CandidateId { get; set; }
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public int CandidateId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public float Amount { get; set; }
        [Required]
        public DateTime DateOfPayment { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string Note { get; set; }
    }
}
