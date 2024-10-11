using System.Collections.Generic;

namespace Supermarket_mvp.Models
{
    internal interface ICategoriesRepository
    {
        IEnumerable<CategoriesModel> GetAll();        
        IEnumerable<CategoriesModel> GetByValue(string value);  
        void Add(CategoriesModel category);           
        void Edit(CategoriesModel category);          
        void Delete(int id);                         
    }
}
