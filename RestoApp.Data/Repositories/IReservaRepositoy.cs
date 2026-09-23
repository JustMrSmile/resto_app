using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestoApp.Entities;


namespace RestoApp.Data.Repositories;

public interface IReservaRepository : IRepository<Reserva>
{
    Task<IEnumerable<Reserva>> GetReservasConDetallesAsync();
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
=======
>>>>>>> 21109d7e49a11ad18a8cc2ff636f6db227a273a9
    Task<IEnumerable<Reserva>> GetReservasSpAsync();
    Task<long> ObtenerOCrearClientePorDniYNombreAsync(long dni, string nombreCliente);
    Task<long> ObtenerOCrearClientePorNombreAsync(string nombreCliente);
    Task<int> CrearReservaEfAsync(DateTime fechaReserva, int cantPersonas, int idEstado, long dniCliente, int? idEvento = null, long? dniEmpleado = null, int? idRol = null, int? idMesa = null);
    Task<int> CrearReservaSpAsync(DateTime fechaReserva, int cantPersonas, int idEstado, long dniCliente, int? idEvento = null, long? dniEmpleado = null, int? idRol = null, int? idMesa = null);
<<<<<<< HEAD
    Task ActualizarMesaReservaAsync(int idReserva, int? idMesa);
    Task CambiarEstadoReservaSpAsync(int idReserva, int nuevoEstadoId);
>>>>>>> Stashed changes
=======
    Task CambiarEstadoReservaSpAsync(int idReserva, int nuevoEstadoId);
    Task ActualizarMesaReservaAsync(int idReserva, int? idMesa);
>>>>>>> 21109d7e49a11ad18a8cc2ff636f6db227a273a9
}