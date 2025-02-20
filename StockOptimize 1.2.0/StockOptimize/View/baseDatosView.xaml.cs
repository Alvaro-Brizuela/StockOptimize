﻿using Microsoft.Win32;
using StockOptimize.Funciones;
using StockOptimize.View.Funciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Lógica de interacción para baseDatosView.xaml
    /// </summary>
    public partial class baseDatosView : Window
    {

        private List<BaseDatos> basesDeDatos = new List<BaseDatos>();


        private void MostrarBasesDeDatos()
        {
            // Aquí agregas lógica para obtener tus bases de datos de alguna fuente
            // Por ahora, simplemente agregaremos algunos datos de ejemplo
            basesDeDatos.Add(new BaseDatos { Nombre = "BaseDatos1", CantidadTablas = 10, FechaModificacion = DateTime.Now });
            basesDeDatos.Add(new BaseDatos { Nombre = "BaseDatos2", CantidadTablas = 20, FechaModificacion = DateTime.Now.AddDays(-1) });
            basesDeDatos.Add(new BaseDatos { Nombre = "BaseDatos3", CantidadTablas = 15, FechaModificacion = DateTime.Now.AddDays(-2) });
            basesDeDatos.Add(new BaseDatos { Nombre = "Base", CantidadTablas = 1552552, FechaModificacion = DateTime.Now.AddDays(-2) });


            // Filtrar elementos nulos o vacíos
            List<BaseDatos> basesDeDatosFiltradas = basesDeDatos.Where(item => !string.IsNullOrEmpty(item.Nombre)).ToList();

            

            // Asignar la lista de bases de datos filtradas al DataGrid para mostrarlas
            dtBaseDatos.ItemsSource = basesDeDatosFiltradas;
        }



        public baseDatosView()
        {
            InitializeComponent();
            //Para que cuando inicie este en pantalla completa
            WindowState = WindowState.Maximized;
            //Para esté en el centro de la pantalla
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            // Establecer el DataContext de la ventana
            DataContext = this;
            // Llamar al método para mostrar las bases de datos
            MostrarBasesDeDatos();

        }

        private void bntCerrarSesión_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog direccionBase = new SaveFileDialog();
            direccionBase.Filter = "SQLite Database Files (*.db)|*.db";  
            if (direccionBase.ShowDialog() == true)
            {
                string direccionDb = $"Data Source={direccionBase.FileName}; Version=3;";
                using (var db = new SQLiteConnection(direccionDb))
                {
                    db.Open();
                }

            }

            string query = $"INSERT INTO Direccion_Base_Datos (Nombre,Direccion.Fecha_Edicion,Creador)"
            Consultas consultas = new Consultas();
            consultas.Escritura(,"./usuarios.db");

        }


        private void btnEditarAcceso_Click(object sender, RoutedEventArgs e)
        {
            //ACA poner cuando se selecciona el boton de editar acceso

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            //aca cuando se aprieta el eliminar
        }

        private void dtBaseDatos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            BaseDatos baseDatosSeleccionada = dtBaseDatos.SelectedItem as BaseDatos;
            

            // Verificar si se ha seleccionado un elemento
            if (baseDatosSeleccionada != null)
            {
                tablaDatosView tablaDatosView = new tablaDatosView(baseDatosSeleccionada);
                tablaDatosView.Show(); 
                this.Close();
            }
        }


    }

    public class BaseDatos
    {
        public string Nombre { get; set; }
        public int CantidadTablas { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
