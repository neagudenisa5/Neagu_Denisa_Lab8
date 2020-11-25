using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Neagu_Denisa_Lab8.Models;

namespace Neagu_Denisa_Lab8.Data
{
    public class Neagu_Denisa_Lab8Context : DbContext
    {
        public Neagu_Denisa_Lab8Context (DbContextOptions<Neagu_Denisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Neagu_Denisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Neagu_Denisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Neagu_Denisa_Lab8.Models.Category> Category { get; set; }
    }
}
