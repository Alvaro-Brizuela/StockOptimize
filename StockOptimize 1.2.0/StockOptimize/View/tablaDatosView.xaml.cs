using System;
using System.Collections.Generic;
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
using Microsoft.Win32;
using StockOptimize.Funciones;
using StockOptimize.View.Funciones;

namespace StockOptimize.View
{
    /// <summary>
    /// Lógica de interacción para tablaDatosView.xaml
    /// </summary>
    public partial class tablaDatosView : Window
    {
        private BaseDatos baseDatosSeleccionada;
        public tablaDatosView(BaseDatos baseDatos)
        {
            InitializeComponent();
            //Para que cuando inicie este en pantalla completa
            WindowState = WindowState.Maximized;
            //Para esté en el centro de la pantalla
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            baseDatosSeleccionada = baseDatos;
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            // Obtener la tabla que el usuario quiere transformar a excel
            string query = "SELECT * FROM 'Usuarios';";
            _ = new DataTable();
            Consultas consulta = new Consultas();
            DataTable tabla = consulta.Lectura(query, "usuarios.db");
            SaveFileDialog direccionArchivo = new SaveFileDialog();
            direccionArchivo.Filter = "Excel Files (*.xlsx)|*.xlsx";

            if (direccionArchivo.ShowDialog() == true)
            {
                Tablas_excel tablas_Excel = new Tablas_excel();
                tablas_Excel.GuardarDatosEnExcel(tabla, direccionArchivo.FileName);
                MessageBox.Show("Excel creado con exito");
            }
        }
    }
}