using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.DIP_Example2
{
    public class FreeFileShareWebsite
    {
        //private IExceptionHandller iex = new FileExceptionHandller();
        private IExceptionHandller iex;
        public FreeFileShareWebsite(IExceptionHandller iex)
        {
            this.iex = iex;
        }

        public void FileUpload(string filePath)
        {
            try
            {

            }
            catch (Exception ex)
            {
                //ExceptionHandller obj = new ExceptionHandller();
                //obj.LogException(ex.ToString());
                iex.LogException(ex.ToString());
            }
        }
    }
}