using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace StockOptimize.View
{
    public partial class Registrar : Window
    {
        private List<string> preguntas = new List<string>()
        {
            "¿Cual es tu fecha de nacimiento?",
            "¿Como se llama tu mejor amigo de la infancia?",
            "¿En que ciudad nacio tu padre?",
            "¿Como se llama tu primer colegio?",
            "¿Como se llama tu primera mascota?"
        };

        public Registrar()
        {
            InitializeComponent();
            AsignarPreguntas();
        }

        private void AsignarPreguntas()
        {
            pregunta_1.Text = preguntas.Any() ? ObtenerPreguntaAleatoria() : "";
            pregunta_2.Text = preguntas.Any() ? ObtenerPreguntaAleatoria() : "";
            pregunta_3.Text = preguntas.Any() ? ObtenerPreguntaAleatoria() : "";
        }


        private string ObtenerPreguntaAleatoria()
        {
            Random random = new Random();
            int index = random.Next(preguntas.Count);
            string pregunta = preguntas[index];
            preguntas.RemoveAt(index);
            return pregunta;
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void txtUser_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPreg_1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPreg_2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPreg_3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            Funciones.Registrar registrar = new Funciones.Registrar(txtUser.Text, txtPass.Password, "usuarios", 1, "Alvaro", "Alvaro", "Alvaro", "Alvaro", "Alvaro", "Juan123");
            registrar.Query();
            registrar.InsertarDatos();
        }
    }
}

/*
    Class Registrar:
    las operaciones principales tienen una complejidad constante, podemos generalizar la complejidad de Registrar() como O(1)
*   Descripcion:
    Esta clase representa la ventana de registro de usuarios en la aplicación.
    Al inicializarse, asigna preguntas aleatorias a los campos correspondientes en la interfaz de usuario.
    Permite al usuario ingresar su nombre de usuario y contraseña.
    Al hacer clic en el botón "Confirmar", crea una instancia de la clase Funciones.Registrar para procesar el registro del usuario.
    La clase Funciones.Registrar se encarga de construir y ejecutar consultas SQL para insertar los datos del usuario en la base de datos.
 */