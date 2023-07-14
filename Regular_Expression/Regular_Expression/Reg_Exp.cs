using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression
{
    public class Reg_Exp
    {
        public void Validate()
        {
            Console.WriteLine("PLease Enter the Email ");
            string eMail = Console.ReadLine();

            string pattern = "^[a-zA-Z0-9.!@#$%&*]+@[A-za-z0-9.]+[a-z]{3}$";
            if (Regex.IsMatch(eMail, pattern))
            {
                Console.WriteLine("The Email has Been Validated ");
                Console.WriteLine("The Valid Email Address is : " + eMail);
            }
            else
            {
                Console.WriteLine("Please Enter the Valid Email ");
            }
        }
    }
}
