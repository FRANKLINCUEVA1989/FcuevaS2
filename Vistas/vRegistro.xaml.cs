namespace FcuevaDS2.Vistas;
public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}
	    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuario = txtUsuario.Text;
		string contrasena = txtContrasena.Text;
		Navigation.PushAsync(new vGrid(usuario, contrasena));

    }
}