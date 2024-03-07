using HciMedico.Library.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HciMedico.Library.Data;

public class AppDbContext : DbContext
{
    //private string connectionString = "Server=localhost;Port=3306;Database=medico;Uid=root;Pwd=root";
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["MedicoConnection"].ConnectionString;

    public DbSet<Test> Tests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Test>().HasData(new Test { Id = 1, TestName = "Test 1", TestNumber = 123456 });
        modelBuilder.Entity<Test>().HasData(new Test { Id = 2, TestName = "Test 2", TestNumber = 789876 });
        modelBuilder.Entity<Test>().HasData(new Test { Id = 3, TestName = "Test 3", TestNumber = 543212 });
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
