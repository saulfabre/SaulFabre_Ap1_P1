using System.Linq.Expressions;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using SaulFabre_Ap1_P1.Context;
using SaulFabre_Ap1_P1.Models;

namespace SaulFabre_Ap1_P1.Services;

public class AutoresServices(IDbContextFactory<Contexto> contextFactory) : IService<Autores, int>
{

    public async Task<Autores?> Buscar(int idAutor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();

        return await contexto.Autores.FirstOrDefaultAsync(a => a.IdAutor == idAutor);
    }

    public async Task<List<Autores>> GetList(Expression<Func<Autores, bool>> criterio)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();

        return await contexto.Autores.Where(criterio).AsNoTracking().ToListAsync();
    }

    public async Task<bool> Existe(int idAutor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();

        return await contexto.Autores.AnyAsync(a => a.IdAutor == idAutor);
    }

    public async Task<bool> Insertar(Autores autor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();

        contexto.Autores.Add(autor);

        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Modificar(Autores autor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();

        contexto.Autores.Update(autor);

        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Eliminar(int idAutor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();

        return await contexto.Autores.Where(a => a.IdAutor == idAutor).ExecuteDeleteAsync() > 0; 
    }

    public async Task<bool> Guardar(Autores autor)
    {
        if (!await Existe(autor.IdAutor))
        {
            return await Insertar(autor);
        }
        else
        {
            return await Modificar(autor);
        }
    }
}
