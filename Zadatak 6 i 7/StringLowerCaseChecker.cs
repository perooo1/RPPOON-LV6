using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_i_7
{
    class StringLowerCaseChecker : StringChecker
    {
        private StringChecker next;

        protected override bool PerformCheck(string stringToCheck)
        {
            if (String.IsNullOrEmpty(stringToCheck)) return false;

            foreach (char c in stringToCheck)
            {
                if (Char.IsLower(c)) return true;
            }
            return false;
        }

    }
}
