using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RestoApp.Desktop.Views;

public partial class NuevaMesaWindow : Window
{
    public NuevaMesaWindow()
    {
        InitializeComponent();
    }

    private void BtnCancelar_Click(object? sender, RoutedEventArgs e)
    {
        Close(); // Cierra la ventana sin hacer nada
    }

    private void BtnGuardar_Click(object? sender, RoutedEventArgs e)
    {
        // Aquí agregaremos la lógica para guardar en base de datos más adelante
        Close();
    }
}