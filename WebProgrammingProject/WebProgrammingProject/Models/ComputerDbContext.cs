using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingProject.Models
{
    public class ComputerDbContext : DbContext
    {
        public ComputerDbContext(DbContextOptions<ComputerDbContext> options) : base(options)
        {

        }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Sales> Sales { get; set; }

    }
}
