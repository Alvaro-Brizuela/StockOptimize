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

namespace StockOptimize.View
{
    /// <summary>
    /// Lógica de interacción para crearBasesView.xaml
    /// </summary>
    public partial class crearBasesView : Window
    {
        private List<string> items = new List<string>();
        public crearBasesView()
        {
            InitializeComponent();
            //Para que cuando inicie este en pantalla completa
            WindowState = WindowState.Maximized;
            //Para esté en el centro de la pantalla
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            string añadir = "Nuevo elemento";

            lbTabla.Items.Add(añadir);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnMoverPrincipio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMoverArriba_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMoverAbajo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMoverFinal_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
