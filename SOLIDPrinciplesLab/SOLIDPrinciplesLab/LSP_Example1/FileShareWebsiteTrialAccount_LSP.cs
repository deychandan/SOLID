using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.LSP_Example1
{
    public class FileShareWebsiteTrialAccount_LSP : IGustAccount
    {
        public string ProvideSpace()
        {
            return "5 GB storage space has been prpvided";
        }

        //public override string AddtoAdditionalBenefits()
        //{
        //    throw new NotImplementedException("Account is not entitled to additional benefits");
        //}
    }
}