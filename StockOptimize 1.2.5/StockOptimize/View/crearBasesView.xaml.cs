﻿using StockOptimize.View.Funciones;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
        private int Columna = 1;
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
                Nombre = $"Columna{Columna}",
                Tipo = "Null",
                NN = false,
                PK = false,
                AI = false,
                U = false
            };
            lbTabla.Items.Add(nuevoElemento);
            Columna += 1;
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=usuarios.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name FROM sqlite_master WHERE type ='table' AND name NOT LIKE 'sqlite_%';";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        MessageBox.Show("Tablas en la base de datos:");
                        while (reader.Read())
                        {
                            string tableName = reader.GetString(0);
                            MessageBox.Show(tableName);
                        }
                    }
                }

                connection.Close();
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
            CrearTabla crearTabla = new CrearTabla();
            crearTabla.Crear(txtTabla.Text, lbTabla);

        }

        private void lbTabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtTabla_TextChanged(object sender, TextChangedEventArgs e)
        {

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
    }
}

/*
    Class crearBasesView:
    el orden depende pues enbtnEliminar_Clixk es o(n) y en los demas es constante
*   Descripcion:
    Esta clase representa la ventana de creación de bases de datos en la aplicación.
    Contiene métodos para añadir elementos a una lista que representa las columnas de la tabla, 
    eliminar elementos de la lista, mover elementos dentro de la lista, actualizar 
    la base de datos con las columnas especificadas, y otros eventos relacionados con la interfaz de usuario.
 */