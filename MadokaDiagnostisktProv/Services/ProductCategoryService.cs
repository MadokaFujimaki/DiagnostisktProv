using MadokaDiagnostisktProv.Data;
using MadokaDiagnostisktProv.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadokaDiagnostisktProv.Services
{
    public class ProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList GetSelectList(Product product)
        {
          return  new SelectList(_context.Set<ProductCategory>(), "ProductCategoryId", "Name", product.ProductCategoryId);
        }
    }
}
