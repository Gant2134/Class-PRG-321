﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //person p = new person();
            //p.HairColor = "Dark";
            // this version has the member variables set to private
            // as a result the we no longer have "direct access to change the variables


           // p.m_FirstName = "Christopher";
           // p.m_LastName = "McCall";
           // p.m_age = 30;

            // the line below will not compile because since we did not specify any access
            // modifier for our m_Haircolor, the defaul access is private, m_Haircolor member Variable

            //p.m_Haircolor = "Dark";

            //the next line declares a reference to an object of the class person,
            //but no actual object corresponds to that reference
            

           // person p1;

            //the line below does not work, since the reference "p1" does not match
            //any exisiting object, we are trying to refer to something that doesnt exist
            // note: that reference is refered to as a variable because a reference is 
            // just a special type of variable.
            // some other types such as integral types; (aka
            // -int
            // -float
            // -double
            // -string)
            // this means they are both object and references at the same time 
            //this means that there is no need to assign an object of type int
            //to a reference of type int,
            // p1.m_age = 18;
            //the following line is possible because SetFirstName is a public method
            //p.SetFirstName("Julien");

            //the following line is using the property LastName. A property is nothing
            //more that and convienient way to write a getter and/or setter and manipulating
            //the inner member variable of the class as if it were a public member
            //(looks like we are accesing a public memeber variable)
            //p.LastName = "Esposito";

           //int MyInterger = 2;
            //MyInterger = 3;
            // const declares a constant which means the variable cannot be changed
            //const int MyOtherInt = 2;
            //MyOtherInt = 3;

            

            
            student pA = new student ("Julien", "Esposito", 35, "Dark", 3.5f);
            student pB = new student ("Christopher", "McCall", 29, "Dark", 2.0f);
            student pC = new student ("Greg", "McKee", 30, "Dark", 1.5f);
            student pD = new student("Timmy", "turner", 18, "brown", 3.0f);
            //Instructor i = new Instructor();
           
            pA.PrintOutContent();
            
           
            pA.PrintGPA(pA.m_gpa);

            Console.WriteLine("Number of items created " + person.NumReferences());

            A.Dictionary_tutorial();
            Student_Roster roster = new Student_Roster();
            roster.Add(pA.ID, pA);
            roster.Add(pB.ID, pB);
            roster.Add(pC.ID, pC);
            student Chris =roster[2];

            pA.m_IPrinter = new ConsolePrinter();
            pB.m_IPrinter = new GuiPrinter();

            pA.Debug();
            pB.Debug();
            
            
            
            
            Console.ReadLine();
            
        }
    }
}
