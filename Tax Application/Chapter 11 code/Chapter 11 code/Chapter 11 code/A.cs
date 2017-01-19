using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_code
{
    public class A
    {
        public static void Dictionary_tutorial()
        {
            //you have a bug here......you fucking missed something and you are super pissed....
            Dictionary<string, A> dict = new Dictionary<string, A>();

            A a1= new A(); a1.m_number = 55;
            A a2= new A(); a2.m_number= 56;
            A a3= new A(); a3.m_number= 57;

            dict.Add("one", a1);
            dict.Add("two", a2);
            dict.Add("three", a3);
            
            A first_reference_of_A = dict["one"];

            Console.WriteLine("element of a dictionary contains value " + first_reference_of_A.m_number);

            return;
        }

        public int m_number;
    }

   
}
