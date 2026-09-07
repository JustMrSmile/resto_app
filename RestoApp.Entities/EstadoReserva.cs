using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestoApp.Entities;

[Table("estado_reserva")]
public class EstadoReserva
{
    [Key]
    [Column("id_estado")]
    public int IdEstado { get; set; }

    [Column("estado")]
    public string Estado { get; set; } = string.Empty;
}