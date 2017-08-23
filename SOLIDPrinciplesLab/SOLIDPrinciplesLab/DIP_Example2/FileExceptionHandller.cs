using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.DIP_Example2
{
    public class FileExceptionHandller : IExceptionHandller
    {
        public void LogException(string ex)
        {
            System.IO.File.WriteAllText(@"D:\TestProject\SOLID\SOLID\SOLIDPrinciplesLab\Log.txt", ex);
        }
    }
}