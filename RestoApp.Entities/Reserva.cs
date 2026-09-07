using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestoApp.Entities;

[Table("reserva")]
public class Reserva
{
    [Key]
    [Column("id_reserva")]
    public int IdReserva { get; set; }
    
    [Column("fecha_reserva")]
    public DateTime FechaReserva { get; set; }
    
    [Column("cant_personas")]
    public int CantPersonas { get; set; }
    
    [Column("dni_cliente")]
    public long DniCliente { get; set; }
    
    [ForeignKey("DniCliente")]
    public Cliente? Cliente { get; set; }

    public ICollection<Mesa> Mesas { get; set; } = new List<Mesa>();
}