using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class Student
    {

        private string Name = "None";

        private int Grade = 0;

        private Instructor Teacher;

        public Student(string Name, Instructor Teacher, int Grade)

        {

            this.Name = Name;
            this.Teacher = Teacher;
            this.Grade = Grade;


        }

        public void SetGrade(int AssignedGrade)

        {

            this.Grade += AssignedGrade;
           

        }

        public string PrintStudentInfo()

        {

            return "Name: " + this.Name + Environment.NewLine + "Grade: " + " " + this.Grade + Environment.NewLine + "Instructor: " + this.Teacher.PrintInstructorInfo() + Environment.NewLine + Environment.NewLine;

        }

    }
}
