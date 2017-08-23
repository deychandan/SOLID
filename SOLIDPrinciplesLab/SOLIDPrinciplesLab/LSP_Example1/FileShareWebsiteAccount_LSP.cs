using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.LSP_Example1
{
    public class FileShareWebsiteAccount_LSP : IPaidAccount
    {
        public virtual string ProvideSpace()
        {
            return "Some storage space has been prpvided";
        }

        public virtual string AddtoAdditionalBenefits()
        {
            return "Add to some additional benefits";
        }
    }
}