using StockOptimize.Funciones;
using StockOptimize.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace StockOptimize.View.Funciones
{
    internal class CrearTabla
    {
        public void Crear(string nombreTabla, ListBox lbTabla)
        {

            // Validación del nombre de la tabla
            if (string.IsNullOrEmpty(nombreTabla))
            {
                MessageBox.Show("Error, ingrese un nombre a la tabla");
                return;
            }

            string TestTabla = $"SELECT COUNT(*) FROM sqlite_master WHERE type ='table' AND name = '{nombreTabla}';";
            Consultas Tabla = new Consultas();
            int Contador_Tabla = Tabla.ComprobarTabla(TestTabla, "./usuarios.db");
            if (Contador_Tabla > 0) 
            {
                MessageBox.Show("Error, ya existe una tabla con ese nombre");
                return;
            }


            // Validación de la existencia de columnas en la lista
            if (lbTabla.Items.Count == 0)
            {
                MessageBox.Show("Error, tabla sin columna");
                return;
            }

            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append($"CREATE TABLE {nombreTabla} (");

            
            foreach (ElementoLista ele in lbTabla.Items)
            {
                string nombrecolum = ele.Nombre;
                string tipo = ele.Tipo;

                // Validación del nombre de la columna
                if (string.IsNullOrEmpty(nombrecolum))
                {
                    MessageBox.Show("Error, columna sin nombre");
                    return;
                }

                // Agregar el nombre de la columna a la consulta
                queryBuilder.Append($"{nombrecolum} ");

                // Determinar el tipo de datos y agregarlo a la consulta
                switch (tipo)
                {
                    case "System.Windows.Controls.ComboBoxItem: Texto":
                        queryBuilder.Append("TEXT");
                        break;
                    case "System.Windows.Controls.ComboBoxItem: Numero":
                    case "System.Windows.Controls.ComboBoxItem: Decimal":
                        queryBuilder.Append("FLOAT");
                        break;
                    case "System.Windows.Controls.ComboBoxItem: Entero":
                        queryBuilder.Append("INTEGER");
                        break;
                    default:
                        MessageBox.Show($"Error, tipo de datos no válido para la columna '{nombrecolum}'");
                        return;
                }

                // Agregar restricciones adicionales si son aplicables
                if (ele.NN)
                {
                    queryBuilder.Append(" NOT NULL");
                }

                if (ele.PK)
                {
                    queryBuilder.Append(" PRIMARY KEY");
                }

                if (ele.AI)
                {
                    // La restricción AUTOINCREMENT debe ir junto a la columna INTEGER PRIMARY KEY
                    if (tipo != "System.Windows.Controls.ComboBoxItem: Entero")
                    {
                        MessageBox.Show($"Error, la columna '{nombrecolum}' debe ser de tipo entero para ser auto incrementable");
                        return;
                    }

                    queryBuilder.Append(" AUTOINCREMENT");
                }

                if (ele.U)
                {
                    queryBuilder.Append(" UNIQUE");
                }

                queryBuilder.Append(", "); // Agregar coma para separar las columnas
            }

            // Eliminar la última coma y espacio agregados
            queryBuilder.Length -= 2;

            queryBuilder.Append(");"); // Cerrar la consulta SQL

            string query = queryBuilder.ToString();

            Consultas CrearTabla = new Consultas();
            CrearTabla.Escritura(query, "./usuarios.db");
        }
    }
}
