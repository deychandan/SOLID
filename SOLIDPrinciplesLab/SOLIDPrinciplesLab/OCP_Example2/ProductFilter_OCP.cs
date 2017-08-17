using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.OCP_Example2
{
    public class ProductFilter_OCP
    {
        public IEnumerable<Product> Search(IList<Product> productList, ISearchBehaviour searchBehaviour)
        {
            return searchBehaviour.Search(productList);
        }
    }
}