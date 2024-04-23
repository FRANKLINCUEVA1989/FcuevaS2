namespace FcuevaDS2.Vistas;

public partial class vInicio : ContentPage
{
	

    public vInicio(string usuario)
    {
        InitializeComponent();
        DisplayAlert("Alerta", " Bienvenido " + usuario, "Cerrar");
        lblUsuario.Text = "Usuario Conectado: " + usuario;
    }

    private void btnPicker_Cliked(object sender, EventArgs e)
    {
		int resultado;
        int resultado1;
        string nombre;
        int notaf;
        nombre= pkEstudiantes.Items[pkEstudiantes.SelectedIndex].ToString();
        resultado = Convert.ToInt32(txtSeguimiento1.Text)/2 + Convert.ToInt32(txtExamen1.Text)/2;

        resultado1 = Convert.ToInt32(txtSeguimiento2.Text)/2 + Convert.ToInt32(txtExamen2.Text)/2;
        notaf = (( resultado + resultado1)/2);
        string fecha = dpFecha.Date.ToString("MM/dd/yyyy");      
        DisplayAlert("Alerta", "NOMBRE: "+ nombre + "\nFECHA: "+ fecha+ 
            " \nNOTA PARCIAL 1: " + resultado+ "\nNOTA PARCIAL 2: " + resultado1 +
            "\nNOTA FINAL: " + notaf , "Cerrar ");
    }

    private void btnPicker1_Cliked(object sender, EventArgs e)
    {
       // int resultado1;
        // resultado1 = Convert.ToInt32(txtSeguimiento2.Text) + Convert.ToInt32(txtExamen2.Text);
       // _ = DisplayAlert("Alerta", " El resultado es " + resultado1, "Cerrar ");
    }

    private void txtSeguimiento1_TextChanged(object sender, TextChangedEventArgs e)
    {
    }
}