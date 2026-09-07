using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RestoApp.Business.Services;
using RestoApp.Data;
using RestoApp.Data.Repositories;

namespace RestoApp.Desktop.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private object? _currentView;

    // Propiedades de visibilidad basadas en el rol global
    public bool EsAdmin => SesionGlobal.TipoUsuarioActual == 1;
    
    // Si el mozo no debe ver clientes, solo devolvemos true si es Admin
    public bool PuedeVerClientes => SesionGlobal.TipoUsuarioActual == 1; 

    // Los mozos y admins sí pueden ver mesas
    public bool PuedeVerMesas => SesionGlobal.TipoUsuarioActual == 1 || SesionGlobal.TipoUsuarioActual == 2;
// 0 = Admin, 1 = Mozo. Empezamos en 1 (Mozo)
    [ObservableProperty]
    private int _indiceRolSeleccionado = 1; 

    // Este método se ejecuta automáticamente cuando IndiceRolSeleccionado cambia
    partial void OnIndiceRolSeleccionadoChanged(int value)
    {
        // Actualizamos la sesión global
        SesionGlobal.TipoUsuarioActual = value == 0 ? 1 : 2;

        // Notificamos a la barra lateral que re-evalúe qué botones mostrar
        OnPropertyChanged(nameof(EsAdmin));
        OnPropertyChanged(nameof(PuedeVerClientes));
        OnPropertyChanged(nameof(PuedeVerMesas));

        // Recargamos la vista central actual para que se apliquen u oculten las columnas
        if (CurrentView is MesasViewModel)
        {
            IrAMesas();
        }
        // Puedes agregar más if() aquí a medida que crees las otras vistas (Clientes, Empleados)
    }


    // Comandos para cambiar de sección al hacer clic en los botones del menú
    [RelayCommand]
    private void IrAClientes()
    {
        // Aquí asignaremos el ViewModel correspondiente al CRUD de clientes más adelante
        // CurrentView = new ClientesViewModel();
    }

    [RelayCommand]
    private void IrAEmpleados()
    {
        // CurrentView = new EmpleadosViewModel();
    }

    [RelayCommand]
    private void IrAReservas()
    {
        // CurrentView = new ReservasViewModel();
    }

    [RelayCommand]
    private void IrAMesas()
    {
        var mesaRepo = new MesaRepository(new RestoAppDbContext());
        var mesaService = new MesaService(mesaRepo);
        CurrentView = new MesasViewModel(mesaService);
    }
    
}