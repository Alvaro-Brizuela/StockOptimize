using System;
using OfficeOpenXml;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockOptimize.View.Funciones
{
    internal class Tablas_excel
    {
        public void GuardarDatosEnExcel(DataTable tabla, string rutaArchivo)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            using (var paquete = new ExcelPackage())
            {
                var hoja = paquete.Workbook.Worksheets.Add(tabla.TableName);
                hoja.Cells["A1"].LoadFromDataTable(tabla, true);
                paquete.SaveAs(new System.IO.FileInfo(rutaArchivo));
                
            }
        }
    }
}

/*
 * Clasa Tablas_excel:
 * o(n) = o(n)
 * Descripcion
    Esta clase proporciona funcionalidad para guardar datos de un DataTable en un archivo de Excel.
    Utiliza la librería EPPlus para trabajar con archivos de Excel.
    Crea un nuevo paquete de Excel.
    Agrega una hoja de trabajo al paquete.
    Carga los datos del DataTable en la hoja de trabajo.
    Guarda el paquete de Excel en la ruta especificada.
 * 
 * 
 */