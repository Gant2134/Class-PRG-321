using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_code
{
    public class Student_Roster : Dictionary <int, student>
    {

        
        

      

        public void Add(int student_id, student Student)
        {
            base.Add(student_id, Student);

            
        }

       // public static void Test_Class()
     //   {
      //      Student_Roster roster = new Student_Roster();
      //      student s1 = new Chapter_11_code.student("Chris", "McCall", 28, "Dark", 3.99f);
        //    student s2 = new Chapter_11_code.student("Chris2", "McCall2", 282, "Dark2", 3.992f);
         //   roster.Add(s1.ID, s1);
        //}
    }  


           
        
 }

