using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class ProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Name = "酒",
                    UnitPrice = 100,
                    ImgUrl = "a.png",
                    Stock = 10
                },
                new Product
                {
                    Name = "酒1",
                    UnitPrice = 200,
                    ImgUrl = "a.png",
                    Stock = 10
                },new Product
                {
                    Name = "酒2",
                    UnitPrice = 300,
                    ImgUrl = "a.png",
                    Stock = 10
                },new Product
                {
                    Name = "酒3",
                    UnitPrice = 400,
                    ImgUrl = "a.png",
                    Stock = 10
                }
            };
            return products;
        }

        public IEnumerable<Product> GetByFilter(decimal request)
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Name = "酒",
                    UnitPrice = 100,
                    ImgUrl = "a.png",
                    Stock = 10
                },
                new Product
                {
                    Name = "酒1",
                    UnitPrice = 200,
                    ImgUrl = "a.png",
                    Stock = 10
                },new Product
                {
                    Name = "酒2",
                    UnitPrice = 300,
                    ImgUrl = "a.png",
                    Stock = 10
                },new Product
                {
                    Name = "酒3",
                    UnitPrice = 400,
                    ImgUrl = "a.png",
                    Stock = 10
                }
            };
            return products.Where(x => x.UnitPrice > request);
        }
    }
}