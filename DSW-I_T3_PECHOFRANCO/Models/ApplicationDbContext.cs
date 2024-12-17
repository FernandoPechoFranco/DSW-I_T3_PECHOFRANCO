using DSW_I_T3_PECHOFRANCO.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Disco> Discos { get; set; } // Asegúrate de que este DbSet coincida con tu modelo.
}

