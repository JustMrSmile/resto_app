using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestoApp.Entities;

[Table("rol_empleado")]
public class RolEmpleado
{
    [Key]
    [Column("id_rol")]
    public int IdRol { get; set; }

    [Column("descripcion")]
    public string Descripcion { get; set; } = string.Empty;

    [Column("permiso_admin")]
    public bool PermisoAdmin { get; set; }
}