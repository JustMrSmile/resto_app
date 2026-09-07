namespace RestoApp.Desktop;

public static class SesionGlobal
{
    // Supongamos: 1 = Administrador, 2 = Mozo
    // Esto se actualizará más adelante cuando el usuario inicie sesión
    public static int TipoUsuarioActual { get; set; } = 2; 
}