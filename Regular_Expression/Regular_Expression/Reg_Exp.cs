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
            Console.WriteLine("PLease Enter the Last Name ");
            string lName = Console.ReadLine();

            string vName = "^[A-Z]{1}[a-z]{2,9}$";
            if (Regex.IsMatch(lName, vName))
            {
                Console.WriteLine("The Last Name has Been Validated ");
                Console.WriteLine("The Valid Last Name is : " + lName);
            }
            else
            {
                Console.WriteLine("Please Enter the Valid Name");
            }
        }
    }
}
