using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab
{
    public class FreeFileShareWebsite_SRP
    {
        public string FileUpload(string filePath)
        {
            string UploadMessage = string.Empty;
            try
            {
                UploadMessage = "File Uploaded Successufully";
            }
            catch (Exception ex)
            {
                CustomExceptionHandler customException = new CustomExceptionHandler();
                customException.LogException(ex.ToString());
            }
            return UploadMessage;
        }
    }
}