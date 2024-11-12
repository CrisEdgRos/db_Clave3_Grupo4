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
/// Forma REporte de de nomina
/// </summary>
namespace Clave3_Grupo4
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo de conexion a la base de datos
        /// </summary>
        Conexion conMysql = new Conexion();
        /// <summary>
        /// Metodo para Mostrar la nomina
        /// </summary>
        public void MostrarNominas()
        {
            //Metodo para calcular la nomina general por mes
            if (string.IsNullOrEmpty(txtEmpleadob.Text))
            {
                dataGridView1.DataSource = conMysql.getData("select codempleado, mes, periodo, sueldobase, bonoventas, horasext, pagohorasext, renta, isss, afp, sueldoneto from nominas where  mes='" + txtMesb.Text.Trim() + "' and periodo='" + txtPeriodob.Text.Trim() + "'");
            //Metodo para calcular la nomina por empleado y por mes seleccionado
            }
            else
            {
                dataGridView1.DataSource = conMysql.getData("select codempleado, mes, periodo, sueldobase, bonoventas, horasext, pagohorasext, renta, isss, afp, sueldoneto from nominas where codempleado='" + txtEmpleadob.Text.Trim() + "' and mes='" + txtMesb.Text.Trim() + "' and periodo='" + txtPeriodob.Text.Trim() + "'");
            }
            //Declaracion de Variables para calcular los totales de cada columna
            double sumasueldobase = 0;
            double sumabonoventas = 0;
            int sumhorasext = 0;
            double sumpagohorasext = 0;
            double sumrenta = 0;
            double sumisss = 0;
            double sumafp = 0; 
            double sumsueldoneto = 0;

            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                sumasueldobase += Convert.ToDouble(row.Cells["sueldobase"].Value);
                sumabonoventas += Convert.ToDouble(row.Cells["bonoventas"].Value); 
                sumhorasext += Convert.ToInt32(row.Cells["horasext"].Value);
                sumpagohorasext += Convert.ToDouble(row.Cells["pagohorasext"].Value);
                sumrenta += Convert.ToDouble(row.Cells["renta"].Value);
                sumisss += Convert.ToDouble(row.Cells["isss"].Value);
                sumafp += Convert.ToDouble(row.Cells["afp"].Value);
                sumsueldoneto += Convert.ToDouble(row.Cells["sueldoneto"].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label
            txtsueldo.Text = Convert.ToString(sumasueldobase);
            txtbonoventas.Text = Convert.ToString(sumabonoventas);
            txthorasext.Text = Convert.ToString(sumhorasext);
            txtpagohorasext.Text = Convert.ToString(sumpagohorasext);
            txtrenta.Text = Convert.ToString(sumrenta);
            txtisss.Text = Convert.ToString(sumisss);
            txtafp.Text = Convert.ToString(sumafp);
            txtsueldoneto.Text = Convert.ToString(sumsueldoneto);
        }


        private void FormReporte_Load(object sender, EventArgs e)
        {
            conMysql.Connect();

        }
        /// <summary>
        /// Boton Mostrar Nomina llama el metodo mostrar nomina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarNominas();
        }
    }
}
