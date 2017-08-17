using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesLab
{
    public interface IFreeFileShareWebsite_NOSRP
    {
        void Login();
        void UploadFile();
        void DownloadFile();
        void Logout();
    }
}
