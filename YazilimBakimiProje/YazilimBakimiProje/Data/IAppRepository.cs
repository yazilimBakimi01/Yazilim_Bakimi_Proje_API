using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBakimiProje.Models;

namespace YazilimBakimiProje.Data
{
   public  interface IAppRepository
    {

        void Add<T>(T entity) where T :class;
        void Delete(int id);
        void SaveAll();
        List<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        



    }
}
