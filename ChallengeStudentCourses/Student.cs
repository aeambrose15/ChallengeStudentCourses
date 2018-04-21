using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public List<Courses> Courses { get; set; }
        public List<Enrollment> Enrollments { get; set; }

    }
}