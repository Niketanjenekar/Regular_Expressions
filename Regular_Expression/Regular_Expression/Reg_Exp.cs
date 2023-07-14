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
            while (true)
            {
                Console.WriteLine("PLease Enter the Email ");
                string eMail = Console.ReadLine();

                string pattern = "^[a-z]{1,}([-.+]{1}){0,1}([0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.][a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";

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
}
