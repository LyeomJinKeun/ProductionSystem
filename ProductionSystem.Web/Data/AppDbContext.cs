using Microsoft.EntityFrameworkCore;
using ProductionSystem.Web.Models;
using System.Collections.Generic;

namespace ProductionSystem.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
    }
}