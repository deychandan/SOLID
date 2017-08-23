using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesLab.LSP_Example1
{
    public interface IPaidAccount : IGustAccount
    {
        string AddtoAdditionalBenefits();
    }
}
