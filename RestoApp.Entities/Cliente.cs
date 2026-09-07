using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestoApp.Entities;

[Table("cliente")]
public class Cliente
{
    [Key]
    [Column("dni_cliente")]
    public long DniCliente { get; set; }

    [ForeignKey("DniCliente")]
    public Persona? PersonaInfo { get; set; } // Propiedad de navegación

    public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}