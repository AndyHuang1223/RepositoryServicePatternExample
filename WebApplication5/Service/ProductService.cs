using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5.Models;
using WebApplication5.Repository;
using WebApplication5.ViewModels.Product;

namespace WebApplication5.Service
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }
        public List<ProductViewModel> GetByFilter(decimal unitPrice)
        {
            
            //return products.Where(x => x.UnitPrice > 200).ToList();
            return _productRepository.GetByFilter(unitPrice).Select(x => new ProductViewModel()
            {
                Name = x.Name,
                UnitPrice = x.UnitPrice
            }).ToList();
        }
    }
}