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
            Console.WriteLine("PLease Enter the Password ");
            string password = Console.ReadLine();

            string pattern = "^[A-Za-z0-9@#$%^&*!]{8}$";
            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("The Password has Been Validated ");
                Console.WriteLine("The Valid Password is : " + password);
            }
            else
            {
                Console.WriteLine("Please Enter the Valid Password ");
            }
        }
    }
}
