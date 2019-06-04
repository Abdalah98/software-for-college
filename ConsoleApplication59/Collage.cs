using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Collage
    {
        public Course mycours;
        public Departments mydepartments;
        public Students myStudentss;
        public Professor myProfessors;
        public Departments[] myDepartments;
        public Professor[] mypro;
        public Students[] mystu;
        public Course[] mycour;
        public string countdepr;
      
        public Course[] cour;
        public Collage()
        {



        }
       

        public int numberOfStudents()
        {
            return Students.numofstudent;
        }
        public int numberOfDepartments()
        {
            return Departments.numofdepa;
        }
        public int numberOfCourses()
        {
            return Course.numofcourses;
        }
        public int numberOfProfessors()
        {
            return Professor.numofpros;
        }
        public Departments findDepartment(String names)
        {

            for (int i = 0; i < myDepartments.Length; i++)
            {

                if (myDepartments[i].name==names)
                {
                    return myDepartments[i];
                    
                }


            } return null;

        }
        public Students findStudent(String names)
        {
            for (int i = 0; i < mystu.Length; i++)
            {
                if (mystu[i].fullName()==names)
                {
                    return mystu[i];
                }

                
            }
            return null;
        }
     public   Professor findProfessor(String name)
        {
            for (int i = 0; i < mypro.Length; i++)
            {
                if (mypro[i].fullName() == name)
                {
                    return mypro[i];
                }


            }
            return null;
        }
      public Course findCourse (String names)
     {
         for (int i = 0; i < mycour.Length; i++)
         {
             if (mycour[i].name == names)
             {
                 return mycour[i];
             }


         }
         return null;
     }
    }
}
