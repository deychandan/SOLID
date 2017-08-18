using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SOLIDPrinciplesLab.OCP_Example2;

namespace SOLIDPrinciplesLab.Controllers
{
    public class OCPDataController : Controller
    {
        IList<Product> lstProduct = new List<Product>();
        public OCPDataController()
        {
            lstProduct.Add(new Product { Brand = "Provogue", Name = "Jeans", Price = "3000", Size = "34", Weight = "205.15" });
            lstProduct.Add(new Product { Brand = "Levis", Name = "T-Shirt", Price = "1000", Size = "XL", Weight = "150.15" });
            lstProduct.Add(new Product { Brand = "Samsung", Name = "LEDTV", Price = "30000", Size = "60", Weight = "3150.15" });
            lstProduct.Add(new Product { Brand = "LG", Name = "Washing Machine", Price = "23000", Size = "120", Weight = "6250.15" });
            lstProduct.Add(new Product { Brand = "Arrow", Name = "Formal Shirt", Price = "5400", Size = "44", Weight = "215.15" });
        }

        // GET: OCPData
        public ActionResult OCPData()
        {
            ////NOOCP way
            //ProductFilter_NOOCP prodSearch = new ProductFilter_NOOCP();
            ////search by name
            //IEnumerable<Product> filterProducts = prodSearch.Search(lstProduct, "Jeans");
            //ViewBag.Brand = filterProducts.FirstOrDefault<Product>().Brand;
            ////search by brand
            ////IEnumerable<Product> filterProductsByWeight = prodSearch.Search(lstProduct, "Jeans");
            ////ViewBag.Brand = filterProductsByWeight.FirstOrDefault<Product>().Name;

            //OCP way
            ProductFilter_OCP prodSearchFilter = new ProductFilter_OCP();
            ISearchBehaviour searchBehaviour;
            IEnumerable<Product> filteredProductsOCP;
            searchBehaviour = new SearchBySizeBehaviour_OCP("44");
            filteredProductsOCP = prodSearchFilter.Search(lstProduct, searchBehaviour);
            ViewBag.Brand = filteredProductsOCP.FirstOrDefault<Product>().Brand;

            return View();
        }
    }
}