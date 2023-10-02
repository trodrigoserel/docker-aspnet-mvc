using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvc1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() {}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}        

        public DbSet<Produto>? Produtos { get; set; }
    }
}