using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBakimiProje.Models;

namespace YazilimBakimiProje.Data
{
    public class AppRepository : IAppRepository
    {
        private DataContext _context;
        public AppRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete(int id)
        {
           var customerToDelete=_context.Customers.FirstOrDefault(c=>c.Id==id);
            _context.Remove(customerToDelete);
        }

        public Customer GetCustomerById(int id)
        {
           var customer =_context.Customers.FirstOrDefault(c=>c.Id==id);
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            var customers = _context.Customers.ToList();
            return customers;
        }

        public void SaveAll()
        {
            _context.SaveChanges();
        }
    }
}
