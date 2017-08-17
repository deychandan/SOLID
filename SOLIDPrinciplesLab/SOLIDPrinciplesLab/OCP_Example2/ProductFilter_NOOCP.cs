using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.OCP_Example2
{
    public class ProductFilter_NOOCP
    {
        public IEnumerable<Product> Search(IList<Product> products, string Name)
        {
            foreach(var item in products)
            {
                if (item.Name == Name)
                    yield return (item);
            }
        }
    }
}