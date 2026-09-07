using RestoApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestoApp.Data.Repositories;

public class MesaRepository : Repository<Mesa>, IMesaRepository
{
    public MesaRepository(RestoAppDbContext context) : base(context) { }

    public async Task<IEnumerable<Mesa>> GetMesasConUbicacionAsync()
    {
        return await _dbSet
            .Include(m => m.Ubicacion)
            .ToListAsync();
    }
}