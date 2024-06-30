using System;
using System.Data;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;

namespace StockOptimize.Funciones
{
    public class Conexion
    {
        private string Basedatos;
        private static Conexion conexion = null;

        private Conexion(string direccion)
        {
            this.Basedatos = direccion;
        }

        public static Conexion GetInstancia(string direccion)
        {
            if (conexion == null)
            {
                conexion = new Conexion(direccion);
            }
            return conexion;
        }

        public SQLiteConnection CrearConexion()
        {
            SQLiteConnection Cadena = new SQLiteConnection();
            Cadena.ConnectionString = "Data Source=" + this.Basedatos;
            return Cadena;
        }
    }

    public class Consultas
    {
        SQLiteConnection conexion = null;
        public DataTable Lectura(string consultaSQL, string direccion)
        {
            DataTable Tabla = new DataTable();

            try
            {
                conexion = Conexion.GetInstancia(direccion).CrearConexion();
                SQLiteCommand comando = new SQLiteCommand(consultaSQL, conexion);
                conexion.Open();
                SQLiteDataReader Valores = comando.ExecuteReader();
                Tabla.Load(Valores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return Tabla;
        }
        public void Escritura(string consultaSQL, string direccion)
        {
            try 
            {
                conexion = Conexion.GetInstancia(direccion).CrearConexion();
                conexion.Open();
                SQLiteCommand comando = new SQLiteCommand(consultaSQL, conexion);
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Operación realizada con éxito.");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                }

            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
        public int ComprobarTabla(string consultaSQL, string direccion)
        {
            int contador = 0;
            try
            {
                conexion = Conexion.GetInstancia(direccion).CrearConexion();
                conexion.Open();
                SQLiteCommand comando = new SQLiteCommand(consultaSQL, conexion);
                try
                {
                    contador = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       

            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return contador;
        }
    }
}



/*  Class Conexion:
 *  t(n) = c 
 *  O(n) = O(1)
 *  
 *  Class Consultas:
 *  -Lectura
 *  t(n) = c*n
 *  O(n) = O(n)
 * 
 * -Escritura
 *  t(n) = c 
 *  O(n) = O(1)
 *  
 *  -ComprobarTabla
 *  t(n) = c 
 *  O(n) = O(1)
 *  
 *  Descripcion:
    Clase Conexion:
    Esta clase gestiona la conexión a la base de datos SQLite.
    Implementa un patrón de diseño Singleton para garantizar que solo haya una instancia de la conexión en toda la aplicación.
    El método CrearConexion() crea y devuelve una nueva instancia de SQLiteConnection utilizando la dirección de la base de datos proporcionada.
    Clase Consultas:
    Esta clase contiene métodos para realizar diferentes operaciones en la base de datos, como lectura, escritura y comprobación de tablas.
    El método Lectura() ejecuta una consulta SQL de lectura y devuelve los resultados en un DataTable.
    El método Escritura() ejecuta una consulta SQL de escritura.
    El método ComprobarTabla() ejecuta una consulta SQL para verificar si una tabla ya existe en la base de datos
*/


