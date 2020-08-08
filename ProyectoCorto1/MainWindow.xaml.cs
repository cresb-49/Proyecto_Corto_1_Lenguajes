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
            Console.WriteLine(textoContenido);
            int cantidadEspacios = 0;
            int inicio = 0;
            while(textoContenido.IndexOf(" ",inicio) != -1)
            {
                cantidadEspacios++;
                inicio = textoContenido.IndexOf(" ", inicio) + 1;
            }
            int primerEspacio =  textoContenido.IndexOf(" ");
            Console.WriteLine(cantidadEspacios);
        }
    }
}
