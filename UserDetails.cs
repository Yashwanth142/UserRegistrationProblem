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
        public static string Reg_pattern3 = "^[a-zA-Z]{1}[a-zA-Z0-9+_.-]+[@]{1}[a-zA-Z]+[.]{1}(co)([.][a-z]{2,})?$";
        public static string Reg_pattern4 = "^[0-9]{2}\\s[0-9]{10}$";
        public static string Reg_pattern5 = "^[A-Z0-9]{1,}[a-zA-Z0-9]{7,}([0-9]+)?$";
        public void UserDetail()
        {
            Console.WriteLine("Enter your First name : ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your Last name : ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter your Email : ");
            string em = Console.ReadLine();
            Console.WriteLine("Enter your Phone number : ");
            string ph = Console.ReadLine();
            Console.WriteLine("enter your password ");
            string pwd = Console.ReadLine();

            bool val1 = Regex.IsMatch(fname, Reg_pattern1);
            bool val2 = Regex.IsMatch(lname, Reg_pattern2);
            bool val3 = Regex.IsMatch(em, Reg_pattern3);
            bool val4 = Regex.IsMatch(ph, Reg_pattern4);
            bool val5 = Regex.IsMatch(pwd, Reg_pattern5);

            if (!val1)
                Console.WriteLine("Invalid First name");
            if (!val2)
                Console.WriteLine("Invalid Last name");
            if (!val3)
                Console.WriteLine("Invalid Email");
            if (!val4)
                Console.WriteLine("Invalid PhoneNumber");
            if (!val5)
                Console.WriteLine("Invalid Password");

        }
    }
}
