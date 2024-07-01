using StockOptimize.Funciones;
using StockOptimize.View;
using StockOptimize.View.Funciones;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockOptimize
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnLogin.Focus(); // Establecer el foco en el botón al cargar el formulario
        }
        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            // Animación de desvanecimiento para el botón
            DoubleAnimation fadeOutAnimation = new DoubleAnimation();
            fadeOutAnimation.To = 0;
            fadeOutAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));

            // Manejador de evento para cuando la animación de desvanecimiento haya terminado
            fadeOutAnimation.Completed += (s, _) =>
            {
                // Minimizar la ventana después de que el botón se haya desvanecido
                WindowState = WindowState.Minimized;
            };

            // Iniciar la animación de desvanecimiento en la propiedad Opacity del botón
            btnMinimizar.BeginAnimation(Button.OpacityProperty, fadeOutAnimation);
        }


        private void btnFinalizar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //Eliminar registros de direccion_base_datos
            /*string query2 = "DELETE FROM Direccion_Bases_Datos";
            Consultas cons = new Consultas();
            cons.Escritura(query2, "./usuarios.db");*/
            string usuario = txtUser.Text;
            string clave = txtPass.Password;
            string query = $"SELECT * FROM Usuarios WHERE Usuario ='{usuario}'";
            Variables_staticas.listaTablas .Clear();
            Variables_staticas.listaDatos.Clear();
            Consultas consulta = new Consultas();
            DataTable datosUsuarios = consulta.Lectura(query, "./usuarios.db");
            Variables_staticas.Usuario = usuario;
            
            query = "SELECT * FROM Direccion_Bases_Datos";
            DataTable basesDatos = consulta.Lectura(query, "./usuarios.db");
            foreach (DataRow row in basesDatos.Rows)
            {
                query = $"SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name NOT LIKE 'sqlite_%';";    
                BaseDatos baseDatos = new BaseDatos();
                baseDatos.Nombre = (string)row["Nombre"];
                baseDatos.direccion = (string)row["Direccion"];
                baseDatos.FechaModificacion = DateTime.Now.ToString();
                baseDatos.Creador = (string)row["Creador"];
                DataTable cantidadTablas = consulta.Lectura(query, baseDatos.direccion);
                baseDatos.CantidadTablas = int.Parse(cantidadTablas.Rows[0][0].ToString());
                Variables_staticas.listaTablas.Add(baseDatos);
                Variables_staticas.BaseDatos = baseDatos.direccion;
            }
            if (datosUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Error, nombre o contraseña incorrecta");
            }
            else if (datosUsuarios.Rows[0]["Clave"].ToString() == clave)
            {
                //Para que se cree
                baseDatosView baseDatosView = new baseDatosView();
                //Para que se muestre
                baseDatosView.Show();
                //Para que la actual se cierre
                this.Close();
            }
            else { MessageBox.Show("Error, nombre o contraseña incorrecta"); }
        }

        private void btnPassReset_Click(object sender, RoutedEventArgs e)
        {
            StockOptimize.View.Registrar VentanaRegis = new StockOptimize.View.Registrar();
            VentanaRegis.Show();
            this.Close();
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtUser_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        private void btnButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                // Llama al mismo método que maneja el clic del ratón
                btnLogin_Click(sender, e);
            }
        }

    }
}
/*
 * MainWindow = O(1)
 * Window_MouseDown = O(1)
 * Window_Loaded = O(1)
 * btnMinimizar_Click = O(1)
 * btnFinalizar_Click = O(1)
 * btnLogin_Click = O(n)
 * btnPassReset_Click = O(1)
 * btnButton_KeyDown = O(1)
 */