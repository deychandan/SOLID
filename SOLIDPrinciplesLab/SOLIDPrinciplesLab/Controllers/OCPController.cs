using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SOLIDPrinciplesLab.OCP_Example2;

namespace SOLIDPrinciplesLab.Controllers
{
    public class OCPController : Controller
    {
        IList<Product> lstProduct = new List<Product>();
        public OCPController()
        {
            lstProduct.Add(new Product { Brand = "Provogue", Name = "Jeans", Price = "3000", Size = "34", Weight = "205.15" });
            lstProduct.Add(new Product { Brand = "Levis", Name = "T-Shirt", Price = "1000", Size = "XL", Weight = "150.15" });
            lstProduct.Add(new Product { Brand = "Samsung", Name = "LEDTV", Price = "30000", Size = "60", Weight = "3150.15" });
            lstProduct.Add(new Product { Brand = "LG", Name = "Washing Machine", Price = "23000", Size = "120", Weight = "6250.15" });
            lstProduct.Add(new Product { Brand = "Arrow", Name = "Formal Shirt", Price = "5400", Size = "44", Weight = "215.15" });
        }
        // GET: OCP
        public ActionResult Index()
        {
            
            return View();
        }
    }
}