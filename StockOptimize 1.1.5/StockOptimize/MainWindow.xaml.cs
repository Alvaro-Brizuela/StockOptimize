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
            string usuario = txtUser.Text;
            string clave = txtPass.Password;
            string query = $"SELECT * FROM Usuarios WHERE Usuario ='{usuario}'";

            Consultas consulta = new Consultas();
            DataTable datosUsuarios = consulta.Lectura(query,"./usuarios.db");
            if (datosUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Error, nombre o contraseña incorrecta");
            }
            else if (datosUsuarios.Rows[0]["Clave"].ToString() == clave)
            {
                //Para que se cree
                crearBasesView crearBasesView = new crearBasesView();
                //Para que se muestre
                crearBasesView.Show();
                //Para que la actual se cierre
                this.Close();
            }
            else { MessageBox.Show("Error, nombre o contraseña incorrecta"); }

        }

        private void btnPassReset_Click(object sender, RoutedEventArgs e)
        {
            Registrar registrar = new Registrar("Juan1", "Juan123", "usuarios", 1 ,"Alvaro", "Alvaro", "Alvaro", "Alvaro", "Alvaro","Juan123");
            registrar.Query();
            registrar.InsertarDatos();
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtUser_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}