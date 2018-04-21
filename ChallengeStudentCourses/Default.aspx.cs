using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
                     List<Courses> courses = new List<Courses>() {
                new Courses() { ClassID = 1, ClassName="Management101", Students=new List<Student>() {
                    new Student() { StudentID = 1, StudentName= "Michael Scott" },
                    new Student() { StudentID = 2, StudentName = "Jim Halpert"}}},
                new Courses() { ClassID = 2, ClassName ="Sales300", Students = new List<Student>() {
                    new Student() { StudentID = 3, StudentName = "Pam Beesly" },
                    new Student() { StudentID = 4, StudentName = "Dwight Schrute"}}},
                new Courses() { ClassID = 3, ClassName = "Accounting200", Students = new List<Student>() {
                    new Student() { StudentID = 5, StudentName = "Kevin Malone"},
                    new Student() { StudentID = 6, StudentName = "Angela Martin"}}}
            };

            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("<br/>Course: {0} - {1}", course.ClassID, course.ClassName);

                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("<br/>&nbsp;&nbsp;Student: {0} - {1}", student.StudentID, student.StudentName);
                }
            }
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            Courses course1 = new Courses() { ClassID = 1, ClassName = "Customer Service 101" };    
            Courses course2 = new Courses() { ClassID = 1, ClassName = "Sales 201" };
            Courses course3 = new Courses() { ClassID = 1, ClassName = "Office Etiquette 300" };
            Courses course4 = new Courses() { ClassID = 1, ClassName = "Human Resources 101" };


            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student { StudentID = 1, StudentName = "Stanley Hudson", Courses = new List<Courses> { course1, course2 }}},
                {2, new Student { StudentID = 2, StudentName = "Toby Henderson", Courses = new List<Courses> { course3, course4}}},
                {3, new Student { StudentID = 3, StudentName = "Kelly Kapour", Courses = new List<Courses> { course1, course3 }}}
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br/>Student: {0} - {1}", student.Value.StudentID, student.Value.StudentName);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br/>&nbsp;&nbsp;Course: {0} {1}", course.ClassID, course.ClassName);
                }
            }

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentID = 10;
            student.StudentName = "Andy Bernard";
            student.Enrollments = new List<Enrollment>() {
                new Enrollment { Grade = 85, Course = new Courses { ClassID = 1, ClassName = "Music 202"}},
                new Enrollment { Grade = 80, Course = new Courses { ClassID = 2, ClassName = "Sales 300"}}
            };

            resultLabel.Text += String.Format("<br/>Student: {0} {1}", student.StudentID, student.StudentName);
            foreach (var enrollment in student.Enrollments)
            {
                resultLabel.Text += String.Format("<br/>Enrolled In: {0} - Grade: {1}", enrollment.Course.ClassName, enrollment.Grade);
            }

        }
    }
}

















