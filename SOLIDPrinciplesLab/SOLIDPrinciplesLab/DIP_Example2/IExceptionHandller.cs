using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesLab.DIP_Example2
{
    public interface IExceptionHandller
    {
        void LogException(string ex);
    }
}
