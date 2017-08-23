using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.ISP_Example1
{
    public class Client3 : IEMail, ISMS
    {
        public void SendEMail()
        {
            throw new NotImplementedException();
        }

        public void SendSMS()
        {
            throw new NotImplementedException();
        }
    }
}