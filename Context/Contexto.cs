using Microsoft.EntityFrameworkCore;
using SaulFabre_Ap1_P1.Models;

namespace SaulFabre_Ap1_P1.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Modelo1> Modelo1 { get; set; }
}
