using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context; 
        }

        public void Seed()
        {
            //verifica se contem dados dentro da base de dados any faz isso do linq
            if (_context.Department.Any() || 
                _context.Seller.Any() || 
                _context.SalesRecord.Any())
            {
                return;
            }

      
        }
    }
}
