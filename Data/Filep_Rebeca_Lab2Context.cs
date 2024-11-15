using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Filep_Rebeca_Lab2.Models;

namespace Filep_Rebeca_Lab2.Data
{
    public class Filep_Rebeca_Lab2Context : DbContext
    {
        public Filep_Rebeca_Lab2Context (DbContextOptions<Filep_Rebeca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Filep_Rebeca_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Filep_Rebeca_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Filep_Rebeca_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
