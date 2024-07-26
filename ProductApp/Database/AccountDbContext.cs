
using Microsoft.EntityFrameworkCore;

namespace ProductApp.Database;
using ProductApp.Models;
public class AccountDbContext : DbContext
    {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=TRD-414\\SQLSERVER1;Initial Catalog=AccountDb;integrated security=true;multipleactiveresultsets=True;Encrypt=False");
    }
    public DbSet<Account> accounts { get; set; }
    public DbSet<Employee> employees { get; set; }
}

