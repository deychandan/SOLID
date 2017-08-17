using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab
{
    public class FreeFileShareWebsite_NOSRP
    {
        public string FileUpload(string filePath)
        {
            string UploadMessage = string.Empty;
            try
            {
                UploadMessage = "File Uploaded Successufully";
            }
            catch(Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Project\SOLID\LogError.txt", ex.ToString());
            }
            return UploadMessage;
        }
    }
}