using System.Linq.Expressions;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using SaulFabre_Ap1_P1.Context;
using SaulFabre_Ap1_P1.Models;

namespace SaulFabre_Ap1_P1.Services;

public class Modelo1Services(IDbContextFactory<Contexto> contextFactory) : IService<Modelo1, int>
{

    public Task<Modelo1?> Buscar(int modelo1Id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Modelo1>> GetList(Expression<Func<Modelo1, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Existe(int modelo1Id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Insertar(Modelo1 modelo1)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Modificar(Modelo1 modelo1)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Eliminar(int modelo1Id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Modelo1 modelo1)
    {
        throw new NotImplementedException();
    }
}
