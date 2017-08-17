using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.OCP_Example1
{
    public class FreeFileShareWebsiteGoldAccount_OCP : FreeFileShareWebsiteAccount_OCP
    {
        public override string ProvideSpace()
        {
            return "105GB storage space provided.";
        }
    }
}