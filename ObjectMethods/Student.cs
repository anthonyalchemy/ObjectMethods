using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectMethods
{
    class Student
    {

        public string name;
        public string major;
        public double gpa;

        public Student (string aName, string aMajor, double aGpa)//constructor
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        //creating object method below 

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}
