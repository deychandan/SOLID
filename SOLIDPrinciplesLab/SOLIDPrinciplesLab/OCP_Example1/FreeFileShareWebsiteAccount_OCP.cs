using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.OCP_Example1
{
    public class FreeFileShareWebsiteAccount_OCP
    {
        public virtual string ProvideSpace()
        {
            return "No storage space provided. Just guest account has been created.";
        }
    }
}