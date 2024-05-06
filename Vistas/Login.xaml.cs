using Microsoft.Maui.Controls;
using System;
namespace JJAENT3.Vistas;

    public partial class Login : ContentPage
{
    private string[] users = { "Carlos", "Ana", "Jose" };
    private string[] passwords = { "carlos123", "ana123", "jose123" };

    public Login()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string enteredUsername = usernameEntry.Text;
        string enteredPassword = passwordEntry.Text;

        for (int i = 0; i < users.Length; i++)
        {
            if (enteredUsername == users[i] && enteredPassword == passwords[i])
            {
                DisplayAlert("Inicio de Sesi�n", "Inicio de sesi�n exitoso", "OK");
                Navigation.PushAsync(new Inicio(users[i]));
                return;
            }
        }

        DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
    }
}
