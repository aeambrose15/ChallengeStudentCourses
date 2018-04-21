using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Courses
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public List<Student> Students { get; set; }

    }
}