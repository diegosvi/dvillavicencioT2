namespace dvillavicencioT2.Vistas;

public partial class vInicio : ContentPage
{
    public vInicio()
    {
        InitializeComponent();
    }

    private void CalcularSuma()
    {
        if (double.TryParse(txtDatoC1.Text, out double valor1) && double.TryParse(txtDatoC2.Text, out double valor2))
        {
            double suma = valor1*0.3 + valor2*0.2;
            txtDatoC3.Text = suma.ToString();
        }
        else
        {
            txtDatoC3.Text = "Ingrese valores numéricos válidos";
        }
    }

    private void CalcularSuma2()
    {
        if (double.TryParse(txtDatoC4.Text, out double valor1) && double.TryParse(txtDatoC5.Text, out double valor2))
        {
            double suma = valor1 * 0.3 + valor2 * 0.2;
            txtDatoC6.Text = suma.ToString();
        }
        else
        {
            txtDatoC6.Text = "Ingrese valores numéricos válidos";
        }
    }

    private void CalcularSuma3()
    {
        if (double.TryParse(txtDatoC3.Text, out double valor1) && double.TryParse(txtDatoC6.Text, out double valor2))
        {
            double suma = valor1 + valor2;
            txtDatoNF.Text = suma.ToString();
        
        if (suma >= 7)
        {
            txtEstado.Text = "Aprobado";
        }
        else if (suma >= 5 && suma <= 6.9)
        {
            txtEstado.Text = "Complementario";
        }
        else
        {
            txtEstado.Text = "Reprobado";
        }
    }
    else
            {
                txtDatoC3.Text = "Ingrese valores numéricos válidos";
                txtEstado.Text = "";
            }
        }

    private void btnPicker_Clicked(object sender, EventArgs e)
    {
        if (pkAlumnos.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "No existe dato", "Cerrar");
        }
        else
        {
            string dato = pkAlumnos.Items[pkAlumnos.SelectedIndex].ToString();
            string fecha = dpFecha.Date.ToString("MM/dd/yyyy");
            string notaParcial1 = txtDatoC3.Text;
            string notaParcial2 = txtDatoC6.Text;
            string notaFinal = txtDatoNF.Text;
            string estado = txtEstado.Text;
            DisplayAlert("Las notas del estudiante son:",
            $"Nombre: {dato}\n" +
            $"Fecha: {fecha} \n" +
            $"Nota Parcial 1: {notaParcial1}\n" +
            $"Nota Parcial 2: {notaParcial2}\n" +
            $"Nota Final: {notaFinal}\n" +
            $"Estado: {estado}",
            "Cerrar");
            
        }
    }

    private void btnPicker3_Clicked(object sender, EventArgs e)
    {
        CalcularSuma();
        CalcularSuma2();
        CalcularSuma3();
    }
}