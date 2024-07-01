using StockOptimize.View.Funciones;
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
            "¿Cuál es tu fecha de nacimiento?",
            "¿Cómo se llama tu mejor amigo de la infancia?",
            "¿En qué ciudad nació tu padre?",
            "¿Cómo se llama tu primer colegio?",
            "¿Cómo se llama tu primera mascota?"
        };

        private List<string> respuestasSeleccionadas = new List<string>(new string[3]);

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
            Random random = new Random(DateTime.Now.Millisecond);
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
            string usuario = txtUser.Text;
            string contrasenha = txtPass.Password;
            string rep_contrasenha = txtRepPass.Password;

            // Obtener las respuestas
            respuestasSeleccionadas[0] = txtPreg_1.Text;
            respuestasSeleccionadas[1] = txtPreg_2.Text;
            respuestasSeleccionadas[2] = txtPreg_3.Text;

            string primera_resp = respuestasSeleccionadas[0];
            string segunda_resp = respuestasSeleccionadas[1];
            string tercera_resp = respuestasSeleccionadas[2];

            // Deja vacia las demas
            string cuarta_resp = "";
            string quinta_resp = "";

            int permisos = 1;
            string acceso = "usuarios";

            Registrar_Usuario registrar = new Registrar_Usuario(
                usuario,
                contrasenha,
                rep_contrasenha,
                acceso,
                permisos,
                primera_resp,
                segunda_resp,
                tercera_resp,
                cuarta_resp,
                quinta_resp
            );

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