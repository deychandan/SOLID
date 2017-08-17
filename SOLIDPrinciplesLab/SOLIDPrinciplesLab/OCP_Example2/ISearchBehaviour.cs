using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesLab.OCP_Example2
{
    public interface ISearchBehaviour
    {
        IEnumerable<Product> Search(IList<Product> productList);
    }
}
