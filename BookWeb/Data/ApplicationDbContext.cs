using BookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWeb.Data
{//böyle durumlarda bir kapatıp açmak lazım derlesekte hata çözmüyor
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories{get; set;}
    }

    
    
}