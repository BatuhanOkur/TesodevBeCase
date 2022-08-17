using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();

        Product GetProduct(Guid id);

        Product CreateProduct(Product product);

        Product UpdateProduct(Product product);

        void DeleteProduct(Guid id);
    }
}
