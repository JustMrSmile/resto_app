using RestoApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestoApp.Data.Repositories;

public class ReservaRepository : Repository<Reserva>, IReservaRepository
{
    public ReservaRepository(RestoAppDbContext context) : base(context) { }

    public async Task<IEnumerable<Reserva>> GetReservasConDetallesAsync()
    {
        return await _dbSet
            .Include(r => r.Cliente)         // Trae el Cliente
                .ThenInclude(c => c.PersonaInfo) // Trae los datos de la Persona (Nombre, DNI)
            .Include(r => r.Mesas)           // Trae la lista de Mesas asignadas
            .ToListAsync();
    }
}