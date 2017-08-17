using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.OCP_Example1
{
    public class FreeFileShareWebsiteTrialAccount_OCP : FreeFileShareWebsiteAccount_OCP
    {
        public override string ProvideSpace()
        {
            return "5GB storage space provided.";
        }
    }
}