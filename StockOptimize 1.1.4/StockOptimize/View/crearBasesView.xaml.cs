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
using System.Windows.Shapes;

namespace StockOptimize.View
{
    /// <summary>
    /// Lógica de interacción para crearBasesView.xaml
    /// </summary>

    public class ElementoLista
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public bool NN { get; set; }
        public bool PK { get; set; }
        public bool AI { get; set; }
        public bool U { get; set; }
    }

    public partial class crearBasesView : Window
    {
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
            var nuevoElemento = new ElementoLista
            {
                Nombre = "Nuevo elemento",
                Tipo = "Numero",
                NN = false,
                PK = false,
                AI = false,
                U = false
            };

            lbTabla.Items.Add(nuevoElemento);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            foreach (var row in lbTabla.Items) 
            {

                /*string nombre = row.Nombre;
                string tipo = row.Tipo;
                bool nn = row.NN;
                bool pk = row.PK;
                bool ai = row.AI;
                bool u = row.U;

                MessageBox.Show(nombre);*/
            }
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

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
