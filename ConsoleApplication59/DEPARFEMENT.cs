using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Departments
    {
        public string name;
        public string description;
        public int sizeofcourses;
        public int sizeofstudent;
        public Boolean isfull;
        public int max_number_of_students;
        public Course[] arr ;
        public Students[] mystudent;
        public int countStudent;
       
        public static int numofdepa;
        public Departments(string n,string d,int s,int z)
        {
            numofdepa++;
            name = n;
            description = d;
            sizeofcourses= s;
            sizeofstudent=z;
            arr = new Course[sizeofcourses];
            mystudent = new Students[z];

        }
        public Departments()
        {

        }
        public int numberOfCourses()
        {
            
            return sizeofcourses;
        }
        public int numberOfStudents()
        {
            return sizeofstudent;

        }
        public Course findCourse(String name)
        {
            
            for (int i = 0; i < sizeofcourses; i++)
            {
                if (arr[i].name == name)
                    return arr[i];
               

            }

            return null;
        }
        public bool isFull()
        {
            if (max_number_of_students == sizeofstudent)
            {
                return true;
            }
            else
                return false;

        }
         public bool enroll(Students s)
        {
             if(countStudent <max_number_of_students)
             {
                 s = new Students();
                 mystudent[countStudent] = s;
                 countStudent++;
                 return true;
             }
             else
             {
                 return false;
             }
            
        }

    }
}
