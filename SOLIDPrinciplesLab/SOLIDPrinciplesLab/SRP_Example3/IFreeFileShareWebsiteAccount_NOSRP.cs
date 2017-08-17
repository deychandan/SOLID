using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesLab.SRP_Example3
{
    public interface IFreeFileShareWebsiteAccount_NOSRP
    {
        void UploadFile(string url);
        void DownloadFile(string url);
        void ShareFileswithOthers(string url);
        //void EarnMoneyOnMovieFileView();
    }
}
