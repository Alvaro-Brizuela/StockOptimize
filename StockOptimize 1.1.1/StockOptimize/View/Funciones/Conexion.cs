using System;
using System.Data;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;

namespace StockOptimize.Funciones
{
    internal class Conexion
    {
        private string Basedatos;
        private static Conexion conexion = null;

        private Conexion()
        {
            this.Basedatos = "./usuarios.db";
        }

        public SQLiteConnection CrearConexion()
        {
            SQLiteConnection Cadena = new SQLiteConnection();
            Cadena.ConnectionString = "Data Source=" + this.Basedatos;
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
    }

    public class Consulta
    {
        public DataTable Listado(string consultaSQL)
        {
            DataTable Tabla = new DataTable();

            SQLiteConnection conexion = null;
            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                SQLiteCommand comando = new SQLiteCommand(consultaSQL, conexion);
                conexion.Open();
                SQLiteDataReader Valores = comando.ExecuteReader();
                Tabla.Load(Valores);
            }
            catch { }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return Tabla;
        }
    }
}