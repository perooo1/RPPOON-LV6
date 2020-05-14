using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_i_7
{
    class PasswordValidator
    {
        StringChecker firstLink;
        StringChecker lastLink;
        
        public PasswordValidator(StringChecker firstLink)
        {
            this.firstLink = firstLink;
            this.lastLink = this.firstLink;
        }

        public void AddLinkToChain(StringChecker newLink)
        {
            lastLink.SetNext(newLink);
            this.lastLink = newLink;
        }

        public bool ValidatePassword(string passwordToValidate)
        {
           return firstLink.Check(passwordToValidate);
        }

    }
}
