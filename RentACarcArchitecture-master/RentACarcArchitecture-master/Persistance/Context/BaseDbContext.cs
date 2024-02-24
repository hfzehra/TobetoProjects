using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Context
{
    public class BaseDbContext :DbContext
    {
        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions) 
        { 
            Configuration = configuration; 
            Database.EnsureCreated(); 
        }
        protected IConfiguration Configuration { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
