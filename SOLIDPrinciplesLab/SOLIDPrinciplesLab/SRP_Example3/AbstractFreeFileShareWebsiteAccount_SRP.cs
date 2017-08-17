using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.SRP_Example3
{
    public abstract class AbstractFreeFileShareWebsiteAccount_SRP : IFreeFileShareWebsiteAccount_NOSRP
    {
        public void UploadFile(string url)
        {
            //Logic to Upload file
        }
        public void DownloadFile(string url)
        {
            //Logic to Download file
        }
        public void ShareFileswithOthers(string url)
        {
            //Logic to Share file
        }
    }
}