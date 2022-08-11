using AppBTS.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    internal class Usuario
    {
        private string nombre;
        private string password;

        public string Nombre //Property para Setear clases con el frame .NET
        { 
            get { return nombre; }
            set { nombre = value; }

        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Usuario() //constructor sin parametros
        {
            nombre = password = string.Empty;
        }
        public Usuario(string nombre, string password) //Constructor con parametros
        {
            this.nombre = nombre;
            this.password = password;
        }

        public bool validar() //Responsabilidad del Usuario, Mètodo propio del usuario
        {
            string consultaSQL = "Select * from Usuarios where usuario='"
                                 + this.Nombre + "' AND password='"
                                 + this.Password + "'";
            DBHelper oDB = new DBHelper();
            if (oDB.consultarDB(consultaSQL).Rows.Count == 0)
                return false;
            else
                return true;

        }
    }
}

    
