using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo4
{
    /// <summary>
    /// 
    /// </summary>
    //Clase Empleados 
    public class empleados:persona
    {
        /// <summary>
        /// Atributos
        /// </summary>
        public double sueldo;
        public string cargos;
        public string cuentabanco;
        public string codempleado;


        public Double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public String Cargos
        {
            get { return cargos; }
            set { cargos = value; }
        }

        public String Cuentabanco
        {
            get { return cuentabanco; }
            set { cuentabanco = value; }
        }

        public String Codempleado
        {
            get { return codempleado; }
            set { codempleado = value; }
        }

        public void generarCodigoe()
        {
            this.codempleado = "EMP" + this.Nombres.Substring(0, 3) + this.Documento.Substring(0, 5);
        }

    }
}
