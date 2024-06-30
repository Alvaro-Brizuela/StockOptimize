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