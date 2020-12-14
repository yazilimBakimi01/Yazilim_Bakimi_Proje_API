﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBakimiProje.Models;

namespace YazilimBakimiProje.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }





    }
}
