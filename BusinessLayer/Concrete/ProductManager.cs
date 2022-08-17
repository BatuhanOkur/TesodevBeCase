using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        ProductRepository productRepository = new ProductRepository();
        public Product CreateProduct(Product product)
        {
            return productRepository.CreateProduct(product);
        }

        public void DeleteProduct(Guid id)
        {
            productRepository.DeleteProduct(id);
        }

        public Product GetProduct(Guid id)
        {
            return productRepository.GetProduct(id);
        }

        public List<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }

        public Product UpdateProduct(Product product)
        {
            return productRepository.UpdateProduct(product);
        }
    }
}
