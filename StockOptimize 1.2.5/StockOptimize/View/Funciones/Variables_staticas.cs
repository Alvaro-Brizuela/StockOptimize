using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StockOptimize.View.Funciones
{
    public class Variables_staticas
    {

        public static string Usuario { get; set; } = null;
        public static List<string> listaTablas { get; set; } = new List<string>();
        
        public static List<BaseDatos> listaDatos { get; set; }
    }
    public class BaseDatos
    {
        public string Nombre { get; set; }
        public int CantidadTablas { get; set; }
        public string FechaModificacion { get; set; }
        public string direccion { get; set; }
    }
}

/*
 * ClasS Variables_staticas:
    o(n) = o(1)
 * Descripcion:
    Esta clase contiene propiedades estáticas que se utilizan para almacenar datos compartidos entre diferentes partes de la aplicación.
    La propiedad estática Usuario se utiliza para almacenar el nombre de usuario.
    La propiedad estática listaTablas se utiliza para almacenar una lista de nombres de tablas.
    La propiedad estática listaDatos se utiliza para almacenar una lista de objetos BaseDatos.

 *  ClasS BaseDatos:
    o(n) = o(1)
 * Descripcion:   
    Esta clase define la estructura de un objeto que representa una base de datos.
    Contiene propiedades para el nombre de la base de datos, la cantidad de tablas, la fecha de modificación y la dirección de la base de datos.
 */