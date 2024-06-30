﻿using System;
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
        private List<TablaDatos> TabladeDatos = new List<TablaDatos>();

        public tablaDatosView(BaseDatos baseDatosSeleccionada)
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.baseDatosSeleccionada = baseDatosSeleccionada;
            MostrarTablaDatos();
        }


        private void MostrarTablaDatos()
        {

            TabladeDatos.Clear();

            if (baseDatosSeleccionada != null)
            {
                //datos cualquiera
                TabladeDatos.Add(new TablaDatos { Nombre = "sisi", Fecha_Modificacion = DateTime.Now, Descripcion = "nerfeen la u" });
                TabladeDatos.Add(new TablaDatos { Nombre = "nono", Fecha_Modificacion = DateTime.Now.AddDays(-1), Descripcion = "como me salgo de la carrera" });

                // Asignar la lista al DataGrid
                dtTablaDatos.ItemsSource = TabladeDatos;
            }
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            baseDatosView baseDatosView = new baseDatosView();
            baseDatosView.Show();
            this.Close();
        }


        //no se en que momento la cree sinceramente 
        private void dtTablaDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            crearBasesView crearBasesView = new crearBasesView();
            crearBasesView.Show();
            this.Close();
        }
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            //para eliminar
        }

        private void btnCrearExcel_Click(object sender, RoutedEventArgs e)
        {
            // Obtener la tabla que el usuario quiere transformar a excel
            string query = "SELECT * FROM 'Direccion_Bases_Datos';";
            _ = new DataTable();
            Consultas consulta = new Consultas();
            DataTable tabla = consulta.Lectura(query, "./usuarios.db");
            SaveFileDialog direccionArchivo = new SaveFileDialog();
            direccionArchivo.Filter = "Excel Files (*.xlsx)|*.xlsx";

            if (direccionArchivo.ShowDialog() == true)
            {
                Tablas_excel tablas_Excel = new Tablas_excel();
                tablas_Excel.GuardarDatosEnExcel(tabla, direccionArchivo.FileName);
                MessageBox.Show("Excel creado con exito");
            }
        }

        private void dtTablaDatos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TablaDatos tablaSeleccionada = dtTablaDatos.SelectedItem as TablaDatos;

            if (tablaSeleccionada != null)
            {
                busquedaView busquedaView = new busquedaView(tablaSeleccionada);
                busquedaView.Show();
                this.Close();
            }

        }
    }
    public class TablaDatos
    {
        public string Nombre { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
        public string Descripcion { get; set; }
    }
}

/*
    Class Registrar:
    la complejidad en el peor de los casos para cada método es constante O(1),dependiendo de las operaciones realizadas dentro de ellos.
    
*   Descripcion:
    Carga y muestra datos de tablas.
    Permite navegar entre diferentes vistas.
    Exporta datos de tablas a Excel.
    Facilita la búsqueda detallada en una tabla.
    Clase TablaDatos:
    Define la estructura de datos para una fila de la tabla
*/