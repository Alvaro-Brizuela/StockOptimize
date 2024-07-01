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
using StockOptimize.Funciones;
using StockOptimize.View.Funciones;

namespace StockOptimize.View
{
    /// <summary>
    /// Lógica de interacción para busquedaView.xaml
    /// </summary>
    public partial class busquedaView : Window
    {
        private TablaDatos tablaSeleccionada;
        public ObservableCollection<Item> Items { get; set; }
        public string direccion_base { get; set; }

        public busquedaView(TablaDatos tablaSeleccionada, string direccion_base)
        {
            this.direccion_base = direccion_base;
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.tablaSeleccionada = tablaSeleccionada;

            if (TablaExiste(tablaSeleccionada.Nombre))
            {
                string consultaSQL = $"SELECT * FROM {tablaSeleccionada.Nombre}";
                DataTable dataTable = ObtenerDatos(consultaSQL);
                ConfigurarDataGrid(dataTable);
            }
            else
            {
                MessageBox.Show($"La tabla {tablaSeleccionada.Nombre} no existe.");
            }
        }

        private DataTable ObtenerDatos(string consultaSQL)
        {
            Consultas consulta = new Consultas();
            return consulta.Lectura(consultaSQL, direccion_base);
        }

        private void ConfigurarDataGrid(DataTable dataTable)
        {
            dataGrid.ItemsSource = dataTable.DefaultView;
        }

        private bool TablaExiste(string tableName)
        {
            string consultaSQL = $"SELECT count(*) FROM sqlite_master WHERE type='table' AND name='{tableName}'";
            Consultas consulta = new Consultas();
            int count = consulta.ComprobarTabla(consultaSQL, direccion_base);
            return count > 0;
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            tablaDatosView tablaDatosView = new tablaDatosView(direccion_base);
            tablaDatosView.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            string filtro = txtBusqueda.Text;
            string consultaSQL = $"SELECT * FROM {tablaSeleccionada.Nombre} WHERE columna LIKE '%{filtro}%'"; // Ajusta la consulta según tus necesidades
            DataTable dataTable = ObtenerDatos(consultaSQL);
            ConfigurarDataGrid(dataTable);
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            // Poner el código que haga cuando haga click en "nuevo"
        }

        private void lbListaNombres_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Poner el código que haga cuando haga doble click en algún elemento para que muestre las características
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
            string consultaSQL = $"SELECT * FROM {tablaSeleccionada.Nombre}";
            DataTable dataTable = ObtenerDatos(consultaSQL);
            ConfigurarDataGrid(dataTable);
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void lbCaracteristicas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
