using System.Collections.Generic;

namespace Supermarket_mvp.Models
{
    internal interface IProductRepository
    {
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByCategory(string value);
        void Add(ProductModel product);
        void Edit(ProductModel product);
        void Delete(int id);
    }
}
