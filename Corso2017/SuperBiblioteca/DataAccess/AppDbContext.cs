using Microsoft.EntityFrameworkCore;
using SuperBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperBiblioteca.DataAccess
{
    
        public class AppDbContext : DbContext
        {
            public AppDbContext()
                : base()
            { }

            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            { }

            public DbSet<Libro> Libro { get; set; }
            public DbSet<Biblioteca> Biblioteca { get; set; }
            public DbSet<Autore> Autore { get; set; }
            
        }
    
}
