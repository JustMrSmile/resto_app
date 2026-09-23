using Avalonia.Controls;
using Avalonia.Interactivity;
using RestoApp.Desktop.ViewModels;

namespace RestoApp.Desktop.Views;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
        DataContext = new LoginViewModel();
    }

    private async void BtnIngresar_Click(object? sender, RoutedEventArgs e)
    {
        if (DataContext is LoginViewModel vm)
        {
            bool exito = await vm.IniciarSesionAsync();
            
            if (exito)
            {
                var mainWindow = new MainWindow();
                mainWindow.Show();
                
                this.Close();
            }
        }
    }
}