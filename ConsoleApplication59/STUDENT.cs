using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Students

    {
        public string firstnames;
        public string lastnames;
        public int ages;
        public string tels;
        public string addresss;
        public Departments mystu;
        public static int numofstudent;
        public Students(string f,string l,int g,string t,string d)
        {
            numofstudent++;
            firstnames = f;
            lastnames = l;
            ages = g;
            tels = t;
            addresss = d;
        }
        public Students()
        {

        }
        public String fullName( )
        {
            string x = firstnames + " " + lastnames;
            return x;
        }
    }
}
