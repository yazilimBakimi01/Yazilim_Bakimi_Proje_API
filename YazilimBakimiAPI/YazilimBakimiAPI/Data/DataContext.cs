using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBakimiAPI.Models;

namespace YazilimBakimiAPI.Data
{
    public class DataContext : DbContext
    {
      
        public DataContext(DbContextOptions<DataContext> options): base (options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Photo> Photos { get; set; }

    }
}
