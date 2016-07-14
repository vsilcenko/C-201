﻿using System;
using System.Collections.Generic;

namespace Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }

        public virtual List<Enrollment> Enrollments { get; set; }
    }
}
