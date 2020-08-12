using ProyectoCorto1.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoCorto1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickAnalizar(object sender, RoutedEventArgs e)
        {
            String textoContenido = textBoxIngresoDatos.Text;
            this.MostrarResultado(textoContenido);

        }
        private void MostrarResultado(String textoContenido)
        {
            InentificadorPalabras ProcesmientoTexto = new InentificadorPalabras();

            List<String> palabras = ProcesmientoTexto.palabrasEncontadas(textoContenido);
            List<String> resultadosConjunto = new List<string>();
            for (int i = 0; i < palabras.Count; i++)
            {
                String cadenaResultado;
                cadenaResultado = palabras.ElementAt(i) + " -> " + ProcesmientoTexto.clasificacionCadena(palabras.ElementAt(i));
                resultadosConjunto.Add(cadenaResultado);
                //Console.WriteLine(cadenaResultado);
            }
            ResultadoExamen ventanaResultados = new ResultadoExamen(resultadosConjunto);
            ventanaResultados.Show();

        }
    }
}
