using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebAplication.Models
{
    public class SalesWebAplicationContext : DbContext
    {
        public SalesWebAplicationContext (DbContextOptions<SalesWebAplicationContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebAplication.Models.Department> Department { get; set; }
    }
}
