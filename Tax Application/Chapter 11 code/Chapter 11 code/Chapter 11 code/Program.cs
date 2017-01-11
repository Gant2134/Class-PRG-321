using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is how we declare a new object of the class person
            //this is also reffered to as instanciating an object of the class person
            //the first part "person p" declaring a reference to an object of the class person
            // the second part "new person" creating an object of the class "person"
            person p = new person();

            p.m_FirstName = "Christopher";
            p.m_LastName = "McCall";
            p.m_age = 30;

            // the line below will not compile because since we did not specify any access
            // modifier for our m_Haircolor, the defaul access is private, m_Haircolor member Variable

            //p.m_Haircolor = "Dark";
        }
    }
}
