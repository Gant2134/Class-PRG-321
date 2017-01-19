using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_code
{
    public class student : person
    {
        private static int id = 0;
        public float m_gpa;

        //set





        public static int Id()
        {
            return id;
        }
        

     




        public student( string fn, string ln, int age, string haircolor, float gpa)
            : base(fn, ln, age, haircolor)
        {
            m_gpa = gpa;
            id = id + 1;
        }

        public void PrintGPA(float m_gpa)
        {
            Console.WriteLine("gpa = " + m_gpa);
            Console.WriteLine("id = " + id);
            
        }



    }
}
