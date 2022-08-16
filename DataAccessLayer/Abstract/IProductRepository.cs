using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductRepository
    {
        List<Product> GetProducts();

        Product GetProduct(Guid id);

        Product CreateProduct(Product product);

        Product UpdateProduct(Product product);

        void DeleteProduct(Guid id);
    }
}
