using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kipasApp.Models;

namespace kipasApp.Data
{
    public class kipasAppDbContext : DbContext
    {
        public kipasAppDbContext (DbContextOptions<kipasAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<kipasApp.Models.Employee> Employee { get; set; } = default!;
    }
}
