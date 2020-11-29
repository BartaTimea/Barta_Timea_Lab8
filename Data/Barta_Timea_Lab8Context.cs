using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Barta_Timea_Lab8.Models;

namespace Barta_Timea_Lab8.Data
{
    public class Barta_Timea_Lab8Context : DbContext
    {
        public Barta_Timea_Lab8Context (DbContextOptions<Barta_Timea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Barta_Timea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Barta_Timea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Barta_Timea_Lab8.Models.Category> Category { get; set; }
    }
}
