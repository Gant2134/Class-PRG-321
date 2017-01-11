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
        //the next three variables are refered to as "member variables" of the class person
        // in other words, those memebr variables are also reffered to as properties
        //the protected attribute

        //if the member variables are not specified as either public protected or private
        //the default is private.
        public string m_FirstName;
        public string m_LastName;
        public int m_age;

        string m_Haircolor;

    }
}
