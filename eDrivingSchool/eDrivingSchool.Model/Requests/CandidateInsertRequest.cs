﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class CandidateInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false)]
        //  [Phone]
        public string Phone { get; set; }
        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^[0-9]{13}$")]
        public string JMBG { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
        public int RoleId { get; set; }
        public byte[] Image { get; set; }
    }
}
