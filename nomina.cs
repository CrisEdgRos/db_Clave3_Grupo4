using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Clase Nomina
/// </summary>
namespace Clave3_Grupo4
{
    /// <summary>
    /// Atributos de la clase nomina
    /// </summary>
    class nomina
    {
        private string mes;
        private string periodo;
        private string codempleado;
        private int horasext;
        private int pagohoras;
        private double salario;
        private double bono;
        private double venta;

        public string Mes { get => mes; set => mes = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string Codempleado { get => codempleado; set => codempleado = value; }
        public int Horasext { get => horasext; set => horasext = value; }
        public int Pagohoras { get => pagohoras; set => pagohoras = value; }
        public double Salario { get => salario; set => salario = value; }
        public double Bono { get => bono; set => bono = value; }
        public double Venta { get => venta; set => venta = value; }

        // Calcula horas extras
        public void calcularHoras()
        {
            this.pagohoras = this.horasext * 5;
        }

        // Calcula bono
        public void calcularbono()
        {
            this.bono = 0;
            if (this.venta > 2000 && this.venta <= 3000)
            {
                this.bono = this.salario * 0.1;
            }
            else if (this.venta > 3000 && this.venta <= 4000)
            {
                this.bono = this.salario * 0.15;
            }
            else if (this.venta >= 4000)
            {
                this.bono = this.salario * 0.2;
            }
            else
            {
                this.bono = 0;
            }
        }
    }
}
