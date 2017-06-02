using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_CSharp
{
    class Student
    {
        public int id;
        public double grade;

        public Student(int id, double grade)
        {
            this.id = id;
            this.grade = grade;
        }

        public void Display()
        {
            Console.WriteLine("ID:" + id, "Grade:" + grade);
        }

        public static Student operator +(Student s1, int num)
        {
            return new Student(s1.id + num, s1.grade + num);
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.grade < s2.grade;
        }

        public static bool operator >(Student s1, Student s2)
        {
            return s1.grade > s2.grade;
        }
    }
}
