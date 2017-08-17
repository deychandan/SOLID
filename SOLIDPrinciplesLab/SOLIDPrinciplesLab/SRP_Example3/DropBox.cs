using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.SRP_Example3
{
    public class DropBox : IFreeFileShareWebsiteAccount_NOSRP
    {
        public void DownloadFile(string url)
        {
            throw new NotImplementedException();
        }

        public void ShareFileswithOthers(string url)
        {
            throw new NotImplementedException();
        }

        public void UploadFile(string url)
        {
            throw new NotImplementedException();
        }
    }
}