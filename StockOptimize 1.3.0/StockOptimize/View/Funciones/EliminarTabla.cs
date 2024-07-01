using StockOptimize.Funciones;
using System;
using System.Windows;

namespace StockOptimize.View.Funciones
{
    internal class EliminarTabla
    {
        public void Eliminar(string nombreTabla)
        {
            if (string.IsNullOrEmpty(nombreTabla))
            {
                MessageBox.Show("Error: El nombre de la tabla no puede estar vacío.");
                return;
            }

            string consultaExisteTabla = $"SELECT COUNT(*) FROM sqlite_master WHERE type ='table' AND name = '{nombreTabla}';";
            Consultas consulta = new Consultas();
            int existeTabla = consulta.ComprobarTabla(consultaExisteTabla, "./usuarios.db");

            if (existeTabla == 0)
            {
                MessageBox.Show("Error: La tabla especificada no existe.");
                return;
            }

            string consultaEliminarTabla = $"DROP TABLE {nombreTabla};";

            try
            {
                consulta.Escritura(consultaEliminarTabla, "./usuarios.db");
                MessageBox.Show("Tabla eliminada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la tabla: " + ex.Message);
            }
        }
    }
}

/*
 * Class Eliminar:
 *  O(n) = O(1)
 * 
 * Descripcion:
 * Esta clase proporciona funcionalidad para eliminar una tabla de una base de datos SQLite.
    Verifica si el nombre de la tabla está vacío.
    Verifica si la tabla especificada existe en la base de datos.
    Ejecuta una consulta SQL para eliminar la tabla especificada.
 */