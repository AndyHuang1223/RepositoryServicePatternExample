using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using WebApplication5.Service;
using WebApplication5.ViewModels.Product;

namespace WebApplication5.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }
        // GET: Product
        public ActionResult Index(int unitPrice)
        {
            //大於200元的商品
            var products = _productService.GetByFilter(unitPrice);
            //var result =  products
            return View(products);
        }
    }
}