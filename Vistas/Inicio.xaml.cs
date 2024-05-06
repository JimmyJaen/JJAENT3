using System.Runtime.InteropServices;

namespace JJAENT3.Vistas;

public partial class Inicio : ContentPage
{
  

    public Inicio(string username)
    {
        InitializeComponent();
        welcomeLabel.Text = $"Bienvenid@, {username}!";


        pickerEstudiante.Items.Add("Jimmy Jaen");
        pickerEstudiante.Items.Add("Erick Lopez");
        pickerEstudiante.Items.Add("Paola Oña");
        pickerEstudiante.Items.Add("Jorge Baculima");
        pickerEstudiante.Items.Add("Jose Chusin");
    }

    private void OnCalcularNotasClicked(object sender, EventArgs e)
    {
        // Obtener valores ingresados
        double seguimiento1 = Convert.ToDouble(txtSeguimiento1.Text);
        double examen1 = Convert.ToDouble(txtExamen1.Text);
        double seguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);
        double examen2 = Convert.ToDouble(txtExamen2.Text);

        // Calculo notas parciales
        double notaParcial1 = (seguimiento1 * 0.3) + (examen1 * 0.2);
        double notaParcial2 = (seguimiento2 * 0.3) + (examen2 * 0.2);

        // Calculo nota final
        double notaFinal = notaParcial1 + notaParcial2;

        // Determinar estado
        string estado = "";
        if (notaFinal >= 7)
        {
            estado = "Aprobado";
        }
        else if (notaFinal >= 5 && notaFinal <= 6.9)
        {
            estado = "Complementario";
        }
        else
        {
            estado = "Reprobado";
        }

        // los resultados
        string mensaje = $"Nota Parcial 1: {notaParcial1}\n" +
                         $"Nota Parcial 2: {notaParcial2}\n" +
                         $"Nota Final: {notaFinal}\n" +
                         $"Estado: {estado}";

        DisplayAlert("Resultados", mensaje, "Aceptar");
    }
}
