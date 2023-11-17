using System;
using System.Windows;

namespace DNICalcular
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularLetra_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Obtener el número ingresado
                int numero = int.Parse(txtNumero.Text);

                // Calcular la letra del NIF
                char letra = CalcularLetraNIF(numero);

                // Mostrar el resultado
                txtResultado.Text = $"La letra del NIF es: {letra}";
            }
            catch (FormatException)
            {
                // Manejar la excepción si el formato es incorrecto
                txtResultado.Text = "Formato incorrecto. Por favor, ingrese un número válido.";
            }
        }

        private char CalcularLetraNIF(int numero)
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            int indice = numero % 23;
            return letras[indice];
        }
    }
}
