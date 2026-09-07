using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestoApp.Entities;

[Table("metodo_pago")]
public class MetodoPago
{
    [Key]
    [Column("id_metodo")]
    public int IdMetodo { get; set; }

    [Column("forma_pago")]
    public string FormaPago { get; set; } = string.Empty;
}