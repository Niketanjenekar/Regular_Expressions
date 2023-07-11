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
            Console.WriteLine("PLease Enter the First Name ");
            string fName = Console.ReadLine();

            string vName = "^[A-Z]{1}[a-z]{2,9}$";
            if (Regex.IsMatch(fName, vName))
            {
                Console.WriteLine("The First Name has Been Validated ");
                Console.WriteLine("The Valid First Name is : " + fName);
            }
            else
            {
                Console.WriteLine("Please Enter the Valid Name");
            }
        }
    }
}
