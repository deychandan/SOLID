using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.OCP_Example2
{
    public class SearchBySizeBehaviour_OCP : ISearchBehaviour
    {
        private string size;

        public SearchBySizeBehaviour_OCP(string size)
        {
            this.size = size;
        }

        public IEnumerable<Product> Search(IList<Product> productList)
        {
            foreach (var item in productList)
            {
                if (item.Size == size)
                    yield return (item);
            }
        }
    }
}