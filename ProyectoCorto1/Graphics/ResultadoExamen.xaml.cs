﻿using System;
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
using System.Windows.Shapes;

namespace ProyectoCorto1.Graphics
{
    /// <summary>
    /// Lógica de interacción para ResultadoExamen.xaml
    /// </summary>
    public partial class ResultadoExamen : Window
    {
        public ResultadoExamen(List<String> resultados)
        {
            InitializeComponent();
            this.agregarResultados(resultados);
        }
        private void agregarResultados(List<String> resultados)
        {
            for (int i = 0; i < resultados.Count; i++)
            {
                listaResultados.Items.Add(resultados.ElementAt(i));
            }
        }
    }
}
