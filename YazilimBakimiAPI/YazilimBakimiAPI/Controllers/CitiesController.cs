using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimBakimiAPI.Data;
using YazilimBakimiAPI.Models;

namespace YazilimBakimiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {

        private IAppRepository _appRepository;

        public CitiesController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        [HttpGet("Cities")]
        public ActionResult GetCities()
        {
            var cities = _appRepository.GetCities();          
            return Ok(cities);
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult Add([FromBody] City city)
        {
            _appRepository.Add(city);
            _appRepository.SaveAll();
            return Ok(city);
        }

        [HttpGet]
        [Route("Detail")]
        public ActionResult GetCitiesById(int id)
        {
            var city = _appRepository.GetCityById(id);         
            return Ok(city);
        }

    }
}
