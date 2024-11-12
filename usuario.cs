using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo4
{
    // Clase Usuario
    public class usuario
    {
        /// <summary>
        /// Atributos
        /// </summary>
        public static String usrapellido;
        public static String usrnombre;
        public static String usrusuario;
        public static String usrcodempleado; 

        public String Usrapellido
        {
            get { return usrapellido; }
            set { usrapellido = value; }
        }

        public string Usrnombre
        {
            get { return usrnombre; }
            set { usrnombre = value; }
        }

        public String Usrusuario
        {
            get { return usrusuario; }
            set { usrusuario = value; }
        }

        public String Usrcodempleado
        {
            get { return usrcodempleado; }
            set { usrcodempleado = value; }
        }

    }
}
