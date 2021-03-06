﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eDrivingSchool.Model.Requests
{
    public class TheoryTestApplicationsInsertRequest
    {
        //  public int Instructor_Category_CandidateId { get; set; }
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public int CandidateId { get; set; }
        public DateTime Date { get; set; }
        public bool FirstAid { get; set; }
        public bool TheoryTest { get; set; }
        //  public Status Status { get; set; }
        public bool Active { get; set; }
    }
}
