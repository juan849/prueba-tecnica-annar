using Microsoft.EntityFrameworkCore;
using prueba_annar_.Net.Models;

namespace prueba_annar_.Net.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Producto> productos { get; set; }

}
