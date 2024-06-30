using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using static StockOptimize.View.busquedaView;

namespace StockOptimize.View
{
    /// <summary>
    /// Lógica de interacción para busquedaView.xaml
    /// </summary>
    public partial class busquedaView : Window
    {
        private TablaDatos tablaSeleccioanda;
        public ObservableCollection<Item> Items { get; set; }
        public busquedaView(TablaDatos tablaSeleccionada)
        {
            InitializeComponent();
            //Para que cuando inicie este en pantalla completa
            WindowState = WindowState.Maximized;
            //Para esté en el centro de la pantalla
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.tablaSeleccioanda = tablaSeleccionada;

            // Crear un DataTable de ejemplo
            DataTable dataTable = new DataTable("MyDataTable");

            //Con esto se añaden las columnas ilimitadas
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("NOMBRE", typeof(string));
            dataTable.Columns.Add("Apellido", typeof(string));

            // Llenar el DataTable con datos de ejemplo
            for (int i = 1; i <= 10; i++)
            {
                dataTable.Rows.Add(i, "Item " + i);
            }

            // Establecer la fuente de datos del DataGrid
            dataGrid.ItemsSource = dataTable.DefaultView;

        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            // AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            //tablaDatosView tablaDatosView = new tablaDatosView(Aca poner la base de datos);
            this.Close();
            //tablaDatosView.Show();
        }


        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            //poner el code cuando apriete el botón de buscar

        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            //Poner aca lo que haga cuando haga click en "nuevo"

        }

        private void lbListaNombres_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Acá cuando le haga doble click a algun elemento para q muestre las características
        }

        public class Item
        {
            public string Nombre { get; set; }
            public string Caracteristica1 { get; set; }
            public string Caracteristica2 { get; set; }
            public string Caracteristica3 { get; set; }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            //Evento cuando se apriete actualizar

        }
    }

}

/*
 * Class busquedaView:
 * el orden depende pues en Data table es o(1) y en ItemsSource del DataGrid es o(n)
 * 
 * Descripcion
    Esta clase representa la ventana de búsqueda en la aplicación.
    Contiene métodos para mostrar los resultados de búsqueda, cerrar la sesión, volver a la ventana anterior, buscar nuevos elementos, y mostrar las características de un elemento al hacer doble clic en él.
 */
