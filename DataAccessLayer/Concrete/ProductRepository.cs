using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class ProductRepository : IProductRepository
    {
        Context dbContext = new Context();
        public Product CreateProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(Guid id)
        {
            var deletedProduct = GetProduct(id);
            dbContext.Products.Remove(deletedProduct);
            dbContext.SaveChanges();
        }

        public Product GetProduct(Guid id)
        {
            return dbContext.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }

        public Product UpdateProduct(Product product)
        {
            dbContext.Products.Update(product);
            dbContext.SaveChanges();
            return product;

        }
    }
}
