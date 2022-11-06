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
                Descripcion ="Vitamina C",
            },
            new Vitaminas{
                VitaminaId = 2,
                Descripcion ="Betaína D",
            },
            new Vitaminas{
                VitaminaId = 3,
                Descripcion ="Vitamina K",
            },
            new Vitaminas{
                VitaminaId = 4,
                Descripcion ="Vitamina B12",
            },
            new Vitaminas{
                VitaminaId = 5,
                Descripcion ="Vitamina B6",
            }, 
            new Vitaminas{
                VitaminaId = 6,
                Descripcion ="Acido fólico(B9)",
            }  
        );
    }
}