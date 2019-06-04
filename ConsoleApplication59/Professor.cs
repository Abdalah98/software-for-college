using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Professor
    {
        
        public string firstnamep;
        public string lastnamep;
        public string telp;
        public string addressp;
        public double salary;
        public static int numofpros;
        public Professor(string f, string l,  string t, string d,double s)
        {
            numofpros++;
            firstnamep = f;
            lastnamep = l;
            telp = t;
            addressp = d;
            salary = s;
        }
        public String fullName( )
        {
            string x = firstnamep + " " + lastnamep;
            return x;
        }
        public double getraise(double raise)
        {
            salary = salary + salary * raise;
            return salary;
        }
    }
    }