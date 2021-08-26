using System;
using System.Collections.Generic;
using System.Text;
using Activity2Canlas.Model;
namespace Activity2Canlas.ViewModel
{
    class StudentViewModel
    {
        public Student StudentSet { get; set; }

        public StudentViewModel()
        {

            StudentSet = new Student
            {
                StudentID = 1,
                Name = "Joseph Raphael M. Canlas",
                CourseCode = "PDC60",
                CourseTitle = "Azure DevOps",
                Units = "3",
                DateofAttendance = "8/26/2021"
            };
        }


    }
}
