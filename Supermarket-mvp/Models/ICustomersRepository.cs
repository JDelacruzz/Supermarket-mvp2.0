using System.Collections.Generic;

namespace Supermarket_mvp.Models
{
    internal interface ICustomersRepository
    {
        IEnumerable<CustomersModel> GetAll(); 
        IEnumerable<CustomersModel> GetByValue(string value); 
        void Add(CustomersModel customer); 
        void Edit(CustomersModel customer); 
        void Delete(int id); 
    }
}
