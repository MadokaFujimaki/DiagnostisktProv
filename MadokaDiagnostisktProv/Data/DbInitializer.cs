using MadokaDiagnostisktProv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadokaDiagnostisktProv.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.ProductCategories.ToList().Count == 0) 
            {
                var tv = new ProductCategory { Name = "TV" };
                var dvd = new ProductCategory { Name = "DVD" };
                var vhs = new ProductCategory { Name = "VHS" };
                context.AddRange(tv, dvd, vhs);
                context.SaveChanges();
            }
        }
    }
}
