using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Deskbug.EntityConfigs;
using Deskbug.Models;

namespace Deskbug.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<User> Users => Set<User>();

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=MCWS\\SQL2019;Database=deskbug;Trusted_Connection=True;");
    }

    // se não for utiliza DataAnnotations
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CategoryEntityConfig());
        builder.ApplyConfiguration(new ProjectEntityConfig());
        builder.ApplyConfiguration(new UserEntityConfig());
    }
}