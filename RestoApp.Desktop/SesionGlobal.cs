using RestoApp.Entities;

namespace RestoApp.Desktop;

public static class SesionGlobal
{

    public static RolUsuario RolActual { get; set; } = RolUsuario.Dueno; 
}