using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
/// <summary>
/// Forma de PDF para cargar el manual de ayuda en PDF
/// </summary>
namespace Clave3_Grupo4
{
    /// <summary>
    /// Classe llamar Archivo PDF
    /// </summary>
    public partial class FormPdf : Form
    {
        public FormPdf()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boton para Mostrar Manual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Metodo para llamar el pdf Manual de usuario Manual_Clave3_Grupo4.Pdf
            usuario remove = new usuario();
            var process = Process.GetCurrentProcess(); // O cualquier método que estés usando
            string fullPath = process.MainModule.FileName;
            string r = fullPath.Substring(0, fullPath.Length - 27) + "mysql"+ "\\" + "Manual_Clave3_Grupo4.pdf";           
            Process.Start(@r);
        }
    }
}
