namespace jescobarS1.Views;

public partial class Empleado : ContentPage
{
	public Empleado()
	{
		InitializeComponent();
	}
    private void OnCalcularClicked(object sender, EventArgs e)
    {
        // Obtener datos de las cajas de texto
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        int edad = int.Parse(txtEdad.Text);
        decimal salario = decimal.Parse(txtSalario.Text);

        // Calcular aporte al IESS (asumiendo un porcentaje del 9.45%)
        decimal aporteIESS = salario * 0.0945m;

        // Mostrar alerta
        DisplayAlert("Resultado",
            $"Bienvenido {nombre} {apellido}\n" +
            $"Tienes {edad} años\n" +
            $"Tu aporte mensual es {aporteIESS:C}",
            "Aceptar");
    }
}