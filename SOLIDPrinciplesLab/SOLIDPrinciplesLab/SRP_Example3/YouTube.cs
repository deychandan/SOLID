using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.SRP_Example3
{
    public class YouTube : AbstractFreeFileShareWebsiteAccount_SRP, IPayMoney
    {
        public void EarnMoneyOnMovieFileView()
        {
            //Logic to earn money
        }
    }
}