using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_i_7
{
    class StringLengthChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if (String.IsNullOrEmpty(stringToCheck))
                return false;
            else
                if (stringToCheck.Length >= 8) return true;
            else
                return false;
            
        }
    }
}
