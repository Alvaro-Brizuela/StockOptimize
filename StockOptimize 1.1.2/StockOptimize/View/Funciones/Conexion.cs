﻿using System;
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
                comando.ExecuteNonQuery();

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
    }
}