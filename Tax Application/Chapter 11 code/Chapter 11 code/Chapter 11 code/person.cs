using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_code
{
    // we make person public, meaning its accessible from other modules can access and use class
    public class person
    {
        private static int NumberReferences = 0;

        public static int NumReferences()
        {
            return NumberReferences;
        }

          //the next three variables are refered to as "member variables" of the class person
        // in other words, those memebr variables are also reffered to as properties
        //the protected attribute

        //if the member variables are not specified as either public protected or private
        //the default is private.

        //edit: because we now want the class student to access the content of the class
        // person we make the member variables protected.
        protected string m_FirstName;
        protected string m_LastName;
        protected int m_age;

        protected string m_Haircolor;

        //this kind of method when you set a member variables is called a setter.
        public void SetFirstName(string firstname)
        {
            // the reason for the underscore m is because otherwise we would have 
            //firstname = firstname which is ambiguous because with such code
            // we have no clue if the meaning is copying the input of the itself
            // copying the member variable to itself, copying the member variable to the input
            //or copying the input to the member variable.
            // had we fucked this up by naming the naming the member varible firstname
            // instead of m_FirstName another way to remove to the ambiguity is to
            // write this.firstname = firstname.
            m_FirstName = firstname;
        }
        //this type of method (reading back the value of a memeber variable is called a getter)
        public string GetFirstName()
        {
            return m_FirstName;
        }

        public string LastName
        {
            get
            {
                return m_LastName;
            }

            set
            {
                m_LastName = value;
            }
        }
        // this is a constructor. because default no imput required also no return value

        public person()
        {
            m_FirstName = "Jane";
            m_LastName = "Doe";
            m_age = 0;

        }

        // this is an parameterized contructor, meaning it takes its one parameters

        public person(string fn, string ln, int age, string haircolor)
        {
            NumberReferences = NumberReferences + 1;
            m_FirstName = fn;
            m_LastName = ln;
            m_age = age;
            m_Haircolor = haircolor;
        }

        //public person( const string person p)
       // {
       // }

        public void PrintOutContent()
        {
            Console.WriteLine("First name = " + m_FirstName);
            Console.WriteLine("Last name = " + m_LastName);
            Console.WriteLine("Age = " + m_age);
            Console.WriteLine("Hair color = " + m_Haircolor);
        }
    }
}
