using HciMedico.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace HciMedico.Library.Data;

public class AppDbContext : DbContext
{
    private string connectionString = "Server=localhost;Port=3306;Database=medico;Uid=root;Pwd=root";

    public DbSet<Test> Tests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Test>().HasData(new Test { Id = 1, TestName = "Test 1" });
        modelBuilder.Entity<Test>().HasData(new Test { Id = 2, TestName = "Test 2" });
        modelBuilder.Entity<Test>().HasData(new Test { Id = 3, TestName = "Test 3" });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            connectionString,
            ServerVersion.AutoDetect(connectionString),
            optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
            );
    }
}
