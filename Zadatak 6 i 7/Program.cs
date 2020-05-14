using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_i_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////// Zadatak 6
            /*
            string test = "TestPassword123";
            string test2 = "TestPassword";

            StringLengthChecker lengthChecker = new StringLengthChecker();
            StringDigitChecker digitChecker = new StringDigitChecker();
            StringUppercaseChecker uppercaseChecker = new StringUppercaseChecker();
            StringLowerCaseChecker lowerCaseChecker = new StringLowerCaseChecker();

            lengthChecker.SetNext(digitChecker);
            digitChecker.SetNext(uppercaseChecker);
            uppercaseChecker.SetNext(lowerCaseChecker);
            lowerCaseChecker.SetNext(null);

            Console.WriteLine(lengthChecker.Check(test));
            Console.WriteLine(lengthChecker.Check(test2));
            */
            ///////////////////////////////////////////////////////////////////////////// Zadatak 7

            string test = "TestPassword123";
            string test2 = "TestPassword";

            StringLengthChecker lengthChecker = new StringLengthChecker();
        
            PasswordValidator validator = new PasswordValidator(lengthChecker);

            validator.AddLinkToChain(new StringDigitChecker());
            validator.AddLinkToChain(new StringUppercaseChecker());
            validator.AddLinkToChain(new StringLowerCaseChecker());

            Console.WriteLine(validator.ValidatePassword(test));
            Console.WriteLine(validator.ValidatePassword(test2));

        }
    }
}
