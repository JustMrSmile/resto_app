namespace RestoApp.Desktop.ViewModels;

public class MesaItemViewModel
{
    public int IdMesa { get; set; }
    public int NroMesa { get; set; }
    public int Capacidad { get; set; }
    public string UbicacionDescripcion { get; set; } = string.Empty; // Aquí irá el texto descriptivo
    public bool PuedeEditar { get; set; }
}