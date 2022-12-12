using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Assignment
{
   public class Person
    {
        //e, last_name, email, cardnumber (9 digits), pincode (4 digits)        stored, and initial balance
        public string first_name { get; set; }
        public string last_name { get; set; }
       
      
        public Person()
        {
            first_name = "User";
            last_name = "1";



        }
    }
}
