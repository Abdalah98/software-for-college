using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("enter the Operations");
            int x = int.Parse(Console.ReadLine());
            switch(x)
            {
                case 1:
                    Collage coll = new Collage();

                    Console.WriteLine();
                    char z =Convert.ToChar( Console.ReadLine());
                  switch (z)  {
                      case 'a':
                          coll.numberOfDepartments();
                          break;
                      case 'b':
                          coll.numberOfCourses();

                          break;
                      case 'c':
                          coll.numberOfProfessors();

                          break;
                      case 'd':
                          coll.numberOfStudents();

                          break;
                    }
                    break;
                case 2:
                    {
 Console.WriteLine();
                    char h =Convert.ToChar( Console.ReadLine());
                  switch (h)
                  {case'a':
                          Console.Write("Enter depar name :");
            string name = Console.ReadLine();
            Console.Write("Enter de description :");
            string description = Console.ReadLine();
            Console.Write("enter sizeofcourses no. : ");
            int sizeofcourses = int.Parse(Console.ReadLine());
            Console.Write("enter sizeofstudent no. : ");
            int sizeofstudent = int.Parse(Console.ReadLine());
            Departments D = new Departments(name, description, sizeofcourses, sizeofstudent); 
                          break;
                      case 'b':
                          D.numberOfCourses();
                          break;
                      case 'c':
                          D.numberOfStudents();
                          break;
                      case 'd':
                          D.isFull();
                          break;
                      case 'e':
                          Students st = new Students();
                          D.enroll(st);
                          break;
                      case 'f':
                          Console.WriteLine("the Report of Departments of collage");
                          break;
                  }
                    } break;
                case 3:
                    {Console.WriteLine();
                    char k =Convert.ToChar( Console.ReadLine());
                  switch (k)
                  {
                      case 'a':
                          Console.Write("Enter depar name :");
            string name = Console.ReadLine();
            Console.Write("Enter de description :");
            string description = Console.ReadLine();
            Console.Write("enter numberofstudents no. : ");
  int numberofstudents = int.Parse(Console.ReadLine());
            Course C = new Course(name, description, numberofstudents);
                          break;
                      case 'b':
                          C.numberOfStudents();
                          break;
                      case 'c':
                          Console.Write("Enter First name :");
            string firstc = Console.ReadLine();
            Console.Write("Enter First name :");
            string lastc= Console.ReadLine();
                           Console.Write("Enter  address:");
            string add= Console.ReadLine();
                           Console.Write("Enter phone :");
            string tel= Console.ReadLine();
             Console.Write("enter slary : ");
             double salary = double.Parse(Console.ReadLine());
                          C.assignedtoaprofessor(firstc,lastc, tel, add,salary);
                          break;
                      case 'e':
                          C.professorname();
                          break;
                      case'f':
                          C.isfull();
                          break;
                      case 'g':
                          Students ss = new Students();
                          C.enroll(ss);
                          break;
                      case'h':
                          Console.WriteLine("the Report of course of collage");
                          break;
                  }
                        

                    }break;
                case 4:
                    
                         {Console.WriteLine();
                    char Q=Convert.ToChar( Console.ReadLine());
                  switch (Q)
                  {
                      case 'a':
                                Console.Write("Enter First name pro :");
            string firstpro = Console.ReadLine();
            Console.Write("Enter last name pro:");
            string lastpro= Console.ReadLine();
                           Console.Write("Enter  address pro:");
            string addpro= Console.ReadLine();
                           Console.Write("Enter phone pro :");
            string telpro= Console.ReadLine();
             Console.Write("enter slary : ");
             double salary = double.Parse(Console.ReadLine());
                          Professor P=new Professor(firstpro,lastpro,addpro,telpro,salary);
                          break;
                      case 'c':
                          Console.WriteLine("ent raise");
                          double raise=double.Parse(Console.ReadLine());
                          P.getraise(raise);
                          break;
                      case 'd':
                          Console.WriteLine("the Report of pro of collage");
                          break;
                  }

                         } break;
                case 5:
                       {Console.WriteLine();
                    char A=Convert.ToChar( Console.ReadLine());
                  switch (A)
                  {
                      case 'a':
                                Console.Write("Enter First name st :");
            string firsts = Console.ReadLine();
            Console.Write("Enter last name st :");
            string lasts= Console.ReadLine();
                          Console.Write("Enter the age :");
            int age= int.Parse( Console.ReadLine());
                           Console.Write("Enter  address st:");

            string adds= Console.ReadLine();
                           Console.Write("Enter phone :");
            string tels= Console.ReadLine();
                          Students S=new Students(firsts,lasts,age,adds,tels);
                          break;
                      case'b':
                          Console.WriteLine("the Report of pro of collage");
                          break;
                  }

                    } break;
                  

                       
            } 


        }
    }
}
