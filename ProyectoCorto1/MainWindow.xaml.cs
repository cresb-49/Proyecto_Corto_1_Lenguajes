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
            InentificadorPalabras ProcesmientoTexto = new InentificadorPalabras();
            
            int acii = System.Convert.ToInt32(Convert.ToChar(textoContenido.Substring(0, 1)));

            Console.WriteLine(acii);

            List<String> palabras = ProcesmientoTexto.palabrasEncontadas(textoContenido);

            for (int i = 0; i < palabras.Count; i++)
            {
                Console.WriteLine(palabras.ElementAt(i));
                Console.WriteLine(ProcesmientoTexto.clasificacionCadena(palabras.ElementAt(i)));
            }
            ProcesmientoTexto.pocesarTexto(palabras);



        }
    }
}
