using RestoApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestoApp.Data.Repositories;

public interface IReservaRepository
{
    Task<IEnumerable<Reserva>> GetReservasConDetallesAsync();
<<<<<<< Updated upstream
=======
    Task<IEnumerable<Reserva>> GetReservasSpAsync();
    Task<long> ObtenerOCrearClientePorDniYNombreAsync(long dni, string nombreCliente);
    Task<long> ObtenerOCrearClientePorNombreAsync(string nombreCliente);
    Task<int> CrearReservaEfAsync(DateTime fechaReserva, int cantPersonas, int idEstado, long dniCliente, int? idEvento = null, long? dniEmpleado = null, int? idRol = null, int? idMesa = null);
    Task<int> CrearReservaSpAsync(DateTime fechaReserva, int cantPersonas, int idEstado, long dniCliente, int? idEvento = null, long? dniEmpleado = null, int? idRol = null, int? idMesa = null);
    Task ActualizarMesaReservaAsync(int idReserva, int? idMesa);
    Task CambiarEstadoReservaSpAsync(int idReserva, int nuevoEstadoId);
>>>>>>> Stashed changes
}