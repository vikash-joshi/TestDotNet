using Microsoft.EntityFrameworkCore;
using MVC_PREP.Models;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}
