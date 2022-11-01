using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Parcial2_Jose_angel.Models;

namespace Parcial2_Jose_angel.Data;
public class Contexto : IdentityDbContext
{
    public DbSet<Vitaminas> Vitaminas { get; set; }
    public DbSet<Verduras> Verduras { get; set; }

    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Vitaminas>().HasData(
            new Vitaminas{
                VitaminaId = 1,
                Nombre ="Vitamina C",
            },
            new Vitaminas{
                VitaminaId = 2,
                Nombre ="Betaína D",
            },
            new Vitaminas{
                VitaminaId = 3,
                Nombre ="Vitamina K",
            },
            new Vitaminas{
                VitaminaId = 4,
               Nombre ="Vitamina B12",
            },
            new Vitaminas{
                VitaminaId = 5,
                Nombre ="Vitamina B6",
            }, 
            new Vitaminas{
                VitaminaId = 6,
                Nombre ="Acido fólico(B9)",
            }  
        );
    }
}