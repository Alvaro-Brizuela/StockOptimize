using StockOptimize.View;
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
            //Para inicializar la otra ventana
            crearBasesView crearBasesView = new crearBasesView();
            //Para que se muestre
            crearBasesView.Show();
            //Para que esta se cierre
            this.Close();
        }

        private void btnPassReset_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}