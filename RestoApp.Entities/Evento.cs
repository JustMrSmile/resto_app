using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestoApp.Entities;

[Table("evento")]
public class Evento
{
    [Key]
    [Column("id_evento")]
    public int IdEvento { get; set; }

    [Column("nombre_evento")]
    public string NombreEvento { get; set; } = string.Empty;
}