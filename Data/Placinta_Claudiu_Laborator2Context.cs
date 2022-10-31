using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Placinta_Claudiu_Laborator2.Models;

namespace Placinta_Claudiu_Laborator2.Data
{
    public class Placinta_Claudiu_Laborator2Context : DbContext
    {
        public Placinta_Claudiu_Laborator2Context (DbContextOptions<Placinta_Claudiu_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Placinta_Claudiu_Laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Placinta_Claudiu_Laborator2.Models.Publisher> Publisher { get; set; }

        public DbSet<Placinta_Claudiu_Laborator2.Models.Author> Author { get; set; }

        public DbSet<Placinta_Claudiu_Laborator2.Models.Category> Category { get; set; }
    }
}
