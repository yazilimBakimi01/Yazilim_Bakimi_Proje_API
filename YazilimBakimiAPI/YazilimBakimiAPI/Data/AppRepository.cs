using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBakimiAPI.Models;

namespace YazilimBakimiAPI.Data
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

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public List<City> GetCities()
        {
            var cities = _context.Cities.ToList();
            return cities;
        }

        public City GetCityById(int cityId)
        {
            var city = _context.Cities.FirstOrDefault(c => c.Id == cityId);
            return city;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
