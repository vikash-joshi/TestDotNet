using Microsoft.EntityFrameworkCore;

namespace WebAPITest.Models
{
    
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
public DbSet<Products> Products { get; set; }
    }

}