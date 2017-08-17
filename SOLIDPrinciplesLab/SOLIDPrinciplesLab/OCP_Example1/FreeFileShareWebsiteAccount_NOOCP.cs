using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.OCP_Example1
{
    public class FreeFileShareWebsiteAccount_NOOCP
    {
        public string AccountType { get; set;}

        public string ProvideSpace()
        {
            if(AccountType=="Trial")
            {
                return "5GB storage space provided";
            }
            else if (AccountType == "Gold")
            {
                return "105GB storage space provided";
            }
            else if (AccountType == "Platinum")
            {
                return "1005GB storage space provided";
            }
            return "No storage space provided";
        }
    }
}