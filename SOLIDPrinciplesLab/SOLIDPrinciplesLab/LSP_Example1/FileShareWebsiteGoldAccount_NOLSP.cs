using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.LSP_Example1
{
    public class FileShareWebsiteGoldAccount_NOLSP : FileShareWebsiteAccount_NOLSP
    {
        public override string ProvideSpace()
        {
            return "105 GB storage space has been prpvided";
        }

        public override string AddtoAdditionalBenefits()
        {
            return "Add to some additional benefits";
        }
    }
}