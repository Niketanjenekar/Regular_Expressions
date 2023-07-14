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
            Console.WriteLine("PLease Enter the Mobile Number ");
            string mobile = Console.ReadLine();

            string pattern = "^[91]+ +[7-9]{2}[0-9]{8}$";
            if (Regex.IsMatch(mobile, pattern))
            {
                Console.WriteLine("The Mobile Number has Been Validated ");
                Console.WriteLine("The Valid Mobile Number is : " + mobile);
            }
            else
            {
                Console.WriteLine("Please Enter the Valid Mobile Number ");
            }
        }
    }
}
