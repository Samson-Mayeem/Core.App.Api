using Core.App.Api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Core.App.Api.Context
{
    public class ContextCon : DbContext
    {
        public ContextCon(DbContextOptions options): base(options)
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<News> news { get; set; }
       public DbSet<Payment> payments { get; set; }    
    }
}
