using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dvillavicencioT2.Vistas;

public partial class vLogin : ContentPage
{

    string[] users = { "Carlos", "Ana", "Jose" };
    string[] passwords = { "carlos123", "ana123", "jose123" };
    public vLogin()
	{
		InitializeComponent();

	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrase�a = txtContrase�a.Text;
        if (txtUsuario.Text == usuario && txtContrase�a.Text == contrase�a)
        {
            Navigation.PushAsync(new vInicio(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contrase�a incorrecto", "Cerrar");
        }
    }
}