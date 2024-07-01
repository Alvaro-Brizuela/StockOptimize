using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StockOptimize.View.Funciones
{
    public class Eliminar_ddbb
    {
        public void Eliminar(string direccion) {
            try
            {
                if (File.Exists(direccion))
                {
                    File.Delete(direccion);
                }

            }catch (Exception e) { MessageBox.Show("Error: ", e.ToString()); }
        } 
    }
}
