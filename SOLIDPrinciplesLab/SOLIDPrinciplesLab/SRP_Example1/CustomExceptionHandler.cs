using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab
{
    public class CustomExceptionHandler
    {
        public void LogException(string exceptionInfo)
        {
            System.IO.File.WriteAllText(@"C:\Project\SOLID\LogError.txt", exceptionInfo);
        }
    }
}