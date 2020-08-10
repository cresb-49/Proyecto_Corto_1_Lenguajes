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
            int acii = System.Convert.ToInt32(Convert.ToChar(textoContenido.Substring(0, 1)));

            Console.WriteLine(acii);

            List<String> palabras = palabrasEncontadas(textoContenido);
            for (int i = 0; i < palabras.Count; i++)
            {
                Console.WriteLine(palabras.ElementAt(i));
            }

            InentificadorPalabras ProcesmientoTexto = new InentificadorPalabras();
            ProcesmientoTexto.pocesarTexto(palabras);


        }
        
        private int contadorEspacios(String cadenaProcesar)
        {
            int inicio = 0;
            int cantidadEspacios = 0;
            while (cadenaProcesar.IndexOf(" ", inicio) != -1)
            {
                if (cadenaProcesar.IndexOf(" ", inicio) > -1)
                {
                    cantidadEspacios++;
                    inicio = cadenaProcesar.IndexOf(" ", inicio) + 1;
                }
            }
            return cantidadEspacios;
        }
        private List<String> palabrasEncontadas(String arreglo)
        {
            List<String> palabras = new List<String>();
            int inicio = 0;
            int fin = 0;
            fin = arreglo.IndexOf(" ")-1;
            for (int i =0; i < contadorEspacios(arreglo); i++)
            {
                palabras.Add(extraerTexto(arreglo, inicio, fin));
                inicio = fin + 2;
                fin = arreglo.IndexOf(" ", inicio) - 1;
            }
            fin = (arreglo.Length)-1;
            palabras.Add(extraerTexto(arreglo, inicio, fin));
            return palabras;
        }
        private String extraerTexto(String cadena, int inicio,int fin)
        {
            String temporal = "";
            for(int i = inicio; i <= fin; i++)
            { 
                temporal = temporal + cadena.Substring(i, 1);
            }
            return temporal;
        }
    }
}
