using GestionaleAcciaieria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleAcciaieria.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base() { }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) { }

        public DbSet<Tubo> Tubo { get; set; }
        public DbSet<Materiale> Materiale { get; set; }
        public DbSet<Posatore> Posatore { get; set; }


    }
}
