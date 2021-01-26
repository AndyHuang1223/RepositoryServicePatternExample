using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImgUrl { get; set; }
        public int Stock { get; set; }

    }
}