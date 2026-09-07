using RestoApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestoApp.Data.Repositories;

public interface IMesaRepository : IRepository<Mesa>
{
    Task<IEnumerable<Mesa>> GetMesasConUbicacionAsync();
}