using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RestoApp.Desktop.Views;

public partial class ConfirmacionWindow : Window
{
    // Constructor por defecto necesario para el diseñador de Avalonia
    public ConfirmacionWindow()
    {
        InitializeComponent();
    }

    // Constructor sobrecargado para recibir el mensaje dinámico
    public ConfirmacionWindow(string mensaje)
    {
        InitializeComponent();
        TxtMensaje.Text = mensaje;
    }

    private void BtnSi_Click(object? sender, RoutedEventArgs e)
    {
        // Cierra la ventana y devuelve 'true' al ShowDialog
        Close(true); 
    }

    private void BtnNo_Click(object? sender, RoutedEventArgs e)
    {
        // Cierra la ventana y devuelve 'false' al ShowDialog
        Close(false); 
    }
}