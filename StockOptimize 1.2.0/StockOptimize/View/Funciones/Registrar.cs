using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using StockOptimize.Funciones;

namespace StockOptimize.View.Funciones
{

    public class Registrar
    {

        private readonly string usuario;
        private readonly string contrasenha;
        private readonly string acceso;
        private readonly string primera_resp;
        private readonly string segunda_resp;
        private readonly string tercera_resp;
        private readonly string cuarta_resp;
        private readonly string quinta_resp;
        private readonly string rep_contrasenha;
        private readonly int permisos;
        private string query;

        public Registrar(string usuario, string contrasenha, string acceso, int permisos, string primera_resp,
               string segunda_resp, string tercera_resp, string cuarta_resp, string quinta_resp, string rep_contrasenha)
        {
            this.usuario        = usuario;
            this.contrasenha    = contrasenha;
            this.acceso         = acceso;
            this.permisos       = permisos;
            this.primera_resp   = primera_resp;
            this.segunda_resp   = segunda_resp;
            this.tercera_resp   = tercera_resp;
            this.cuarta_resp    = cuarta_resp;
            this.quinta_resp    = quinta_resp;
            this.rep_contrasenha= rep_contrasenha;
        }
        public void Query()
        {
            if (contrasenha == rep_contrasenha)
            {
                this.query =
                $@"INSERT INTO Usuarios (Usuario, Clave, Acce_ddbb, Permisos, Fecha_nacimiento, Mejor_amig_inf, Ciudad_padre, Primer_colege, Primera_mascota) 
                VALUES ('{usuario}',  '{contrasenha}', '{acceso}',  '{permisos}', '{primera_resp}', '{segunda_resp}', '{tercera_resp}', '{cuarta_resp}', '{quinta_resp}')";
            }
            else
            {
                MessageBox.Show("Error, las contraseñas no coinciden");
                return;
            }
        }
        public void InsertarDatos() 
        {
            Consultas consulta = new Consultas();
            consulta.Escritura(this.query, "./usuarios.db");
            MessageBox.Show("Reguistro exitoso");
        }
    }
}



/*
 * Class Registrar
 * T(n) = O(n)
 * O(n) = O(1)
 */