using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestoApp.Entities;

[Table("empleado")]
public class Empleado
{
    [Key]
    [Column("dni_empleado")]
    public long DniEmpleado { get; set; }

    [ForeignKey("DniEmpleado")]
    public Persona? PersonaInfo  { get; set; }

    [Column("id_rol")]
    public int IdRol { get; set; }

    [ForeignKey("IdRol")]
    public RolEmpleado? Rol { get; set; }

    [Column("id_turno")]
    public int IdTurno { get; set; }

    [ForeignKey("IdTurno")]
    public TurnoEmpleado? Turno { get; set; }

    [Column("activo_en_rol")]
    public bool ActivoEnRol { get; set; }
}