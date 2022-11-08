using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Deskbug.EntityConfigs;
using Deskbug.Models;

namespace BugTracker.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=MCWS\\SQL2019;Database=deskbug;Trusted_Connection=True;");
    }

    // se não for utiliza DataAnnotations
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CategoryEntityConfig());
    }
}