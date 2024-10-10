using System.Collections.Generic;

namespace Supermarket_mvp.Models
{
    internal interface IProductRepository
    {
        IEnumerable<ProductModel> GetAll();
        ProductModel GetById(int id);
        void Add(ProductModel product);
        void Edit(ProductModel product);
        void Delete(int id);
    }
}
