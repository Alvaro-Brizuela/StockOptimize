using Microsoft.Win32;
using StockOptimize.Funciones;
using StockOptimize.View.Funciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
using System.Xml.Linq;

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
            foreach (BaseDatos row in Variables_staticas.listaTablas) 
            {
                basesDeDatos.Add(new BaseDatos { Nombre = row.direccion, CantidadTablas = row.CantidadTablas, FechaModificacion = row.FechaModificacion });
            }

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
            BaseDatos baseDatosSeleccionada = dtBaseDatos.SelectedItem as BaseDatos;
            string NombreBase = null;
            string creador;
            SaveFileDialog direccionBase = new SaveFileDialog();
            direccionBase.Filter = "SQLite Database Files (*.db)|*.db";

            if (direccionBase.ShowDialog() == true)
            {
                NombreBase = System.IO.Path.GetFileName(direccionBase.FileName);
                string direccionDb = $"Data Source={direccionBase.FileName}; Version=3;";
                using (var db = new SQLiteConnection(direccionDb))
                {
                    db.Open();
                    db.Close();
                }
            }
            creador = Variables_staticas.Usuario;
            BaseDatos agregar = new BaseDatos();
            agregar.Nombre = NombreBase;
            agregar.FechaModificacion = DateTime.Now.ToString();
            agregar.direccion = direccionBase.FileName;
            agregar.Creador = creador;
            agregar.CantidadTablas = 0;
            Variables_staticas.listaTablas.Add(agregar);
            DateTime fecha = DateTime.Now;
            basesDeDatos.Clear();
            foreach (BaseDatos row in Variables_staticas.listaTablas)
            {
                basesDeDatos.Add(new BaseDatos { Nombre = row.direccion, CantidadTablas = row.CantidadTablas, FechaModificacion = row.FechaModificacion });
            }
            List<BaseDatos> basesDeDatosFiltradas = basesDeDatos.Where(item => !string.IsNullOrEmpty(item.Nombre)).ToList();
            dtBaseDatos.ItemsSource = null;
            dtBaseDatos.ItemsSource = basesDeDatosFiltradas;
            string query = $"INSERT INTO Direccion_Bases_Datos (Nombre, Direccion, Fecha_Edicion, Creador) " +
                $"VALUES ('{NombreBase}','{direccionBase.FileName}', '{fecha}', '{creador}')";

            Consultas consultas = new Consultas();
            consultas.Escritura(query, "./usuarios.db");

        }

        private void btnEditarAcceso_Click(object sender, RoutedEventArgs e)
        {
            //ACA poner cuando se selecciona el boton de editar acceso

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            BaseDatos baseDatosSeleccionada = dtBaseDatos.SelectedItem as BaseDatos;
            Eliminar_ddbb eliminarBase = new Eliminar_ddbb();
            eliminarBase.Eliminar(baseDatosSeleccionada.Nombre);
            BaseDatos eliminar = null;
            foreach (BaseDatos row in Variables_staticas.listaTablas)
            {
                if (row.direccion == baseDatosSeleccionada.Nombre) 
                {
                    eliminar = row; break;
                }
            }
            Variables_staticas.listaTablas.Remove(eliminar);
            basesDeDatos.Clear();
            foreach (BaseDatos row in Variables_staticas.listaTablas)
            {
                basesDeDatos.Add(new BaseDatos { Nombre = row.direccion, CantidadTablas = row.CantidadTablas, FechaModificacion = row.FechaModificacion });
            }
            List<BaseDatos> basesDeDatosFiltradas = basesDeDatos.Where(item => !string.IsNullOrEmpty(item.Nombre)).ToList();
            dtBaseDatos.ItemsSource = null;
            dtBaseDatos.ItemsSource = basesDeDatosFiltradas;
            Consultas consultas = new Consultas();
            string query = $"DELETE FROM Direccion_Bases_Datos WHERE Direccion = '{baseDatosSeleccionada.Nombre}'";
            consultas.Escritura(query, "./usuarios.db");
        }

        private void dtBaseDatos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            BaseDatos baseDatosSeleccionada = dtBaseDatos.SelectedItem as BaseDatos;

            Variables_staticas.listaDatos.Clear();
            // Verificar si se ha seleccionado un elemento
            if (baseDatosSeleccionada != null)
            {
                string query = $"SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";
                Consultas consulta = new Consultas();
                DataTable dt = consulta.Lectura(query, baseDatosSeleccionada.Nombre);
                foreach (DataRow row in dt.Rows) 
                {
                    Variables_staticas.listaDatos.Add(row["name"].ToString());
                }
                tablaDatosView tablaDatosView = new tablaDatosView(baseDatosSeleccionada.Nombre);
                tablaDatosView.Show(); 
                this.Close();
            }
        }

        private void dtBaseDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
/*
 * Class baseDatosView:
 * Descripcion
    Esta clase representa la ventana de la aplicación para mostrar y gestionar bases de datos.
    Contiene métodos para mostrar las bases de datos disponibles, crear una nueva base de datos, editar acceso, eliminar y abrir una base de datos seleccionada.
 */