using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimBakimiProje.Data;
using YazilimBakimiProje.Models;

namespace YazilimBakimiProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersContoller : ControllerBase
    {
        private IAppRepository _appRepository;

        public CustomersContoller(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        [HttpGet("Customers")]
        public ActionResult GetCustomers()
        {
            var customers = _appRepository.GetCustomers();
            return Ok(customers);

        }

        [HttpGet("Customer")]
        public ActionResult GetCustomersById(int id)
        {
            var customer = _appRepository.GetCustomerById(id);
            return Ok(customer);
        }

        [HttpPost("Add")]
        public ActionResult AddCustomer([FromBody]Customer c)
        {
            _appRepository.Add(c);
            _appRepository.SaveAll();
            return Ok (c);

        }

        [HttpPost("Delete")]

        public ActionResult DeleteCustomer(int id)
        {
            _appRepository.Delete(id);
            _appRepository.SaveAll();
            return Ok();
        }






    }
}
