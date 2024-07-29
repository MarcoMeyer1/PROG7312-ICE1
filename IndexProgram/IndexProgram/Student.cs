using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexProgram
{
    public class Student
    {
        private string studentId, firstName, lastName, course;
        private double grade;

        public Student(string studentId, string firstName, string lastName, string course, double grade)
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.course = course;
            this.grade = grade;
        }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.studentId;
                    case 1:
                        return this.firstName;
                    case 2:
                        return this.lastName;
                    case 3:
                        return this.course;
                    case 4:
                        return this.grade;
                    default:
                        return null;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.studentId = (string)value;
                        break;
                    case 1:
                        this.firstName = (string)value;
                        break;
                    case 2:
                        this.lastName = (string)value;
                        break;
                    case 3:
                        this.course = (string)value;
                        break;
                    case 4:
                        this.grade = (double)value;
                        break;
                }
            }
        }

        public object this[string attributeName]
        {
            get
            {
                switch (attributeName)
                {
                    case "studentId":
                        return this.studentId;
                    case "firstName":
                        return this.firstName;
                    case "lastName":
                        return this.lastName;
                    case "course":
                        return this.course;
                    case "grade":
                        return this.grade;
                    default:
                        return null;
                }
            }
            set
            {
                switch (attributeName)
                {
                    case "studentId":
                        this.studentId = (string)value;
                        break;
                    case "firstName":
                        this.firstName = (string)value;
                        break;
                    case "lastName":
                        this.lastName = (string)value;
                        break;
                    case "course":
                        this.course = (string)value;
                        break;
                    case "grade":
                        this.grade = (double)value;
                        break;
                }
            }
        }
    }
}
