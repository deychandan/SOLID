using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.DIP_Example2
{
    public class EventViewerHandller : IExceptionHandller
    {
        public void LogException(string ex)
        {
            //log exception in eventviewer
        }
    }
}