using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Deskbug.EntityConfigs;
using Deskbug.Models;

namespace Deskbug.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Company> Companies => Set<Company>();
    public DbSet<Priority> Priorities => Set<Priority>();
    public DbSet<Severity> Severities => Set<Severity>();
    public DbSet<TicketType> TicketTypes => Set<TicketType>();
    public DbSet<User> Users => Set<User>();

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=MCWS\\SQL2019;Database=deskbug;Trusted_Connection=True;Encrypt=False;");
        //builder.UseSqlServer("Server=MCWS\\SQL2019;Database=mcws;User Id=mcws;Password=mcws;Encrypt=False;");
    }

    // se não for utiliza DataAnnotations
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CategoryEntityConfig());
        builder.ApplyConfiguration(new ProjectEntityConfig());
        builder.ApplyConfiguration(new UserEntityConfig());
        builder.ApplyConfiguration(new CompanyEntityConfig());
        builder.ApplyConfiguration(new PriorityEntityConfig());
        builder.ApplyConfiguration(new SeverityEntityConfig());
        builder.ApplyConfiguration(new TicketTypeEntityConfig());
    }
}