﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBakimiAPI.Models;

namespace YazilimBakimiAPI.Data
{
  public  interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();
        List<City> GetCities();


    }
}
