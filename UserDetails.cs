using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{ 
    public class UserDetails
    {
        public static string Reg_pattern1 = "^[A-Z]{1}[a-z]{2}[a-z]+$";
        public static string Reg_pattern2 = "^[A-Z]{1}[a-z]{2}[a-z]+$";
        public static string Reg_pattern3 = "^[a-zA-Z]+[@]{1}[a-zA-Z]+[.]{1}[a-z]{3}$";
        public void UserDetail()
        {
            Console.WriteLine("Enter your First name : ");
            string fname = Console.ReadLine(); 
            Console.WriteLine("Enter your Last name : ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter your Email : ");
            string em = Console.ReadLine();

            bool val1 = Regex.IsMatch(fname, Reg_pattern1);
            bool val2 = Regex.IsMatch(lname, Reg_pattern2);
            bool val3 = Regex.IsMatch(em, Reg_pattern3);

            if (!val1)
              Console.WriteLine("Invalid First name");
            if(!val2)
              Console.WriteLine("Invalid Last name");
            if (!val3)
                Console.WriteLine("Invalid Email");

        }
    }
}
