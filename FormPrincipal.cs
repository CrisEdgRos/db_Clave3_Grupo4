using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Menu Principal de la aplicacion
/// </summary>
namespace Clave3_Grupo4
{
    /// <summary>
    /// Form Menu Principal
    /// </summary>
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            menuStrip2.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }
        /// <summary>
        /// Metodos de cambio y asignacion de colores de la forma
        /// </summary>
        public class MyColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.DarkSeaGreen;
                }
            }

            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.DarkSeaGreen;
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.DarkSeaGreen;
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.DarkSeaGreen;
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.DarkGreen;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.DarkGreen;
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.DarkGreen;
                }
            }

            public override Color MenuStripGradientBegin
            {
                get
                {
                    return Color.DarkGreen;
                }
            }

            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.DarkGreen;
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.DarkGreen;
                }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.DarkGreen;
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.DarkGreen;
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.DarkGreen;
                }
            }
        }

        public void ExitApplication()
        {
            // Metodo para Salir de la aplicacion
            if (MessageBox.Show("Seguro que deseas salir?", "MiEmpaque",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                MessageBox.Show("!!!... Gracias vuelva pronto ...!!!");
                Application.Exit();
            }
        }
        /// <summary>
        /// Abre Form Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mantenimientoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios usuarios = new FormUsuarios();
            usuarios.Show();
        }
        /// <summary>
        /// Abre Form Planilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generarPlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNomina nomina = new FormNomina();
            nomina.Show();
        }
        /// <summary>
        /// Abre Form Factura de CLiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crearFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactura factura = new FormFactura();
            factura.Show();
        }
        /// <summary>
        /// Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
        /// <summary>
        /// Abre Form Mantenimiento de Empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mantenimientoEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados empleados = new FormEmpleados();
            empleados.Show();
        }
        /// <summary>
        /// Abre Form Reporte Nominas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportesnominasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte reporte = new FormReporte();
            reporte.Show();
        }
        /// <summary>
        /// Abre Form Documentacion FormPdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void documentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPdf pdf = new FormPdf();
            pdf.Show();
        }
    }
}
