using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo4
{
    //Clase Persona
    public class persona
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private String apellidos;
        private String nombres;
        private String direccion;
        private String telefono;
        private string documento;
        private string correo;
        private string tipo;


        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }
}
