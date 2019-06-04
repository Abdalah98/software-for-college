using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Course
    {
        public string name;
        public string description;
        public string professorName;
        public int MAX_NUMBER_OF_STUDENTS ;
        public int number_of_lectures;
        public int numberofstudents;
        public int countstudent;
       
        public Professor pro=null;
         public Students[] students;
         public static int numofcourses = 0;
        public Course(string n, string d,int si)
        {
            numofcourses++;

            numberofstudents = si;
    name=n;
    description=d;
}
        public int numberOfStudents()
        {
            return numberofstudents;
        }
       public bool assignedtoaprofessor(string first,string last,string tel,string add,double s)
        {
            if (pro == null)
            {
                pro = new Professor(first, last, tel, add,s);
                return true;
            }
            else
                return false;

      
       }
        public void unassignProfessor(Professor p)
       {
           if ( pro == p)
           {
             pro = null;
           }
       }  
      
       public string professorname()
        {
            return pro.firstnamep + " " + pro.lastnamep;
       }
        public bool fullstudent()
       {
           if (MAX_NUMBER_OF_STUDENTS == numberofstudents)
           { return true; }
           else 
    return false ;
       }
        public bool isfull()
        {
            if (MAX_NUMBER_OF_STUDENTS == numberofstudents)
            {
                return true;
            }
            else
                return false;

        }
        //low fe mkan ydef low mafe4 false
    public bool enroll(Students s)
        {
            if (countstudent < MAX_NUMBER_OF_STUDENTS)
            {
                s = new Students();
                students[countstudent] = s;
                countstudent++;
                return true;

            }
            else
                return false;
        }

    }
    
}
