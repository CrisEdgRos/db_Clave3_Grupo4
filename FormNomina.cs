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
/// Forma de Nominas
/// </summary>
namespace Clave3_Grupo4
{
    public partial class FormNomina : Form
    {
        public FormNomina()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo de Conexion a la base de datos
        /// </summary>
        Conexion conMysql = new Conexion();
        nomina cnomina = new nomina();

        /// <summary>
        /// Metodo para guardar en la nomina las horas extras en caso que haya tenido un empleado
        /// </summary>
        public void GuardarNomina()
        {
            cnomina.Mes = Convert.ToString(cb_mesbus.SelectedValue);
            cnomina.Periodo = textPeriodob.Text.Trim();
            cnomina.Horasext = Convert.ToInt32(txtHorasEx.Text.Trim());
            cnomina.Codempleado = Convert.ToString(cb_empleados.SelectedValue);
            cnomina.calcularHoras();

            String sql = String.Format("update nominas set horasext='{0}', PagoHorasExt='{4}' where codempleado='{1}' and mes='{2}' and periodo='{3}'",
                                 cnomina.Horasext, cnomina.Codempleado, cnomina.Mes, cnomina.Periodo, cnomina.Pagohoras);
            try
            {
                //Validaciones de ingreso de horas extras
                if (conMysql.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Horas extra agregado de manera éxitosa ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se puedo agregar horas extra ...!!!");
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Metodo para calcular la nomina de un empleado 
        /// </summary>
        public void CalcularNomina()
        {
            dataGridView1.DataSource = conMysql.getData("select * from nominas where mes='" + cb_mescal.SelectedValue + "' and periodo='" + textPeriodoCal.Text.Trim() + "'");
            try
            {
                int contar = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    // Recorre los valores en la datagrid 

                    string codempleado = "";
                    codempleado = Convert.ToString(dataGridView1.Rows[i].Cells["codempleado"].Value);
                    //Declaracion de variables para calculo de bono
                    double sueldoneto = 0;
                    double venta = 0;

                    String sql2 = "select IFNULL(sum(valor_total),0) as venta from facturas where codempleado='" + codempleado + "' and DATE_FORMAT(fecha, '%c')= " + Convert.ToString(dataGridView1.Rows[i].Cells["mes"].Value) + " and DATE_FORMAT(fecha, '%Y')=" + Convert.ToString(dataGridView1.Rows[i].Cells["periodo"].Value) + "";
                    DataRow busq1 = conMysql.getRow(sql2);
                    //Calculo de Bono en caso de que se haya cumplido meta de ventas
                    if (busq1 != null){ venta = Convert.ToDouble(busq1["venta"]); } else { venta = 0; }

                    cnomina.Salario = Convert.ToDouble(dataGridView1.Rows[i].Cells["sueldobase"].Value);
                    cnomina.Venta = venta;
                    cnomina.calcularbono();

                    sueldoneto = cnomina.Salario + cnomina.Bono + Convert.ToDouble(dataGridView1.Rows[i].Cells["PagoHorasExt"].Value) - Convert.ToDouble(dataGridView1.Rows[i].Cells["renta"].Value) - Convert.ToDouble(dataGridView1.Rows[i].Cells["isss"].Value) - Convert.ToDouble(dataGridView1.Rows[i].Cells["afp"].Value);

                    String sql = String.Format("update nominas set BonoVentas='{0}', VentaMes='{5}',sueldoneto='{1}' where codempleado='{2}' and mes= '{3}' and periodo='{4}'",
                          cnomina.Bono, sueldoneto, codempleado, Convert.ToString(dataGridView1.Rows[i].Cells["mes"].Value),Convert.ToString(dataGridView1.Rows[i].Cells["periodo"].Value), venta);
                    try
                    {

                        if (conMysql.Query(sql) == 1)
                        {
                            contar = contar + 1;
                        }
                        else
                        {
                            contar = 0;
                        }

                       // limpiar();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //limpiar();
                }
                if (contar >= 1)
                {
                    MessageBox.Show("!!!... Cálculo de nómina exitoso:" + cb_mescal.SelectedValue +"/"+ textPeriodoCal.Text + " ...!!!");
                }
                else { MessageBox.Show("!!!... ERROR, NO se pudo calcular nómina ...!!!"); }
                MostrarNominas3();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPrincipal menu = new FormPrincipal();
            menu.Show();
            this.Hide();
        }
        /// <summary>
        /// Metodo para seleccionar el mes que se desea calcular la nomina 
        /// </summary>
        public void MostrarNominas()
        {
            //Nueva Nomina
            dataGridView1.DataSource = conMysql.getData("select * from nominas where mes='" + cb_mesn.SelectedValue +"' and periodo='" + txtPeriodon.Text.Trim() +"'");
        }

        public void MostrarNominas2()
        {
            //Horas extras
            dataGridView1.DataSource = conMysql.getData("select * from nominas where mes='" + cb_mesbus.SelectedValue + "' and periodo='" + textPeriodob.Text.Trim() + "'");
        }

        public void MostrarNominas3()
        {
            //Calcular Planilla
            dataGridView1.DataSource = conMysql.getData("select * from nominas where mes='" + cb_mescal.SelectedValue + "' and periodo='" + textPeriodoCal.Text.Trim() + "'");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Boton Buscar datos del empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String sql = "select * from nominas where codempleado = '" + cb_empleados.SelectedValue + "' and mes='" + cb_mesbus.SelectedValue + "' and periodo='" + textPeriodob.Text.Trim() + "'";
            DataRow fila = conMysql.getRow(sql);
            if (fila != null)
            {
                txtNombre.Text = fila["Nombre"].ToString();
                txtApellido.Text = fila["Apellido"].ToString();
                txtCargo.Text = fila["Cargo"].ToString();
                MostrarNominas2();
            }
            //Validacion Buscar Empleado
            else
            {
                MessageBox.Show("No existe empleado en la nomina");
            }
        }
        /// <summary>
        /// Metodo Limpiar Campos
        /// </summary>
        public void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCargo.Text = "";
            txtHorasEx.Text = "";

            conMysql.Connect();
            String sql = "select id, concat(id,' - ',mes) mes from mes";
            conMysql.CargarCombo(cb_mesn, sql, "mes", "id");


            String sql2 = "select id, concat(id,' - ',mes) mes from mes where id in (select mes from nominas)";
            conMysql.CargarCombo(cb_mesbus, sql2, "mes", "id");
            conMysql.CargarCombo(cb_mescal, sql2, "mes", "id");

            String sql3 = "select codempleado, concat(codempleado, ' - ', nombre,' ', apellido) nombre from empleados";
            conMysql.CargarCombo(cb_empleados, sql3, "nombre", "codempleado");

        }

        public void limpiar2()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCargo.Text = "";
            txtHorasEx.Text = "";

        }

        /// <summary>
        /// Boton Guardar nomina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarNomina_Click(object sender, EventArgs e)
        {
            //Validaciones que esten llenos los campos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }
            else if (string.IsNullOrEmpty(txtHorasEx.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }
            else if (string.IsNullOrEmpty(textPeriodob.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }
            else
            {
                GuardarNomina();
                //  btnGuardarNomina.Habilitada = falsa;
                MostrarNominas2();
                limpiar2();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // btnBuscar.Habilitada = falsa;
            //  btnGuardarNomina.Habilitada = falsa;
            // txtID.Enabled = true;
            //  txtCargo.Clear();
            //  txtApellido.Clear();
            if (txtPeriodon.Text.Trim() == String.Empty )
            {
                MessageBox.Show("!!!... Error, los campos no pueden estar vacios ...!!!");
                return;
            }

            if (txtPeriodon.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar oeriodo");
                return;
            }
            //Elimina en la tabla nominas de la base de datos
            String sql2 = String.Format("delete from nominas where mes='{0}' and periodo='{1}'", cb_mesn.SelectedValue, txtPeriodon.Text.Trim());
            conMysql.Query(sql2);
            //Agrega en la tabla nomina de la base de datos
            String sql = String.Format("insert into nominas(nombre, apellido, cargo, sueldobase, horasext, ventames, PagoHorasExt, bonoventas, renta, isss, afp, sueldoneto, mes, periodo, codempleado)" +
                          " select nombre, apellido, cargo, salario, 0, 0, 0, 0, salario*0.1 , salario*0.03, salario*0.0725, 0,'{0}','{1}', codempleado  from empleados",
                           cb_mesn.SelectedValue, txtPeriodon.Text.Trim());

            try
            {
                //Validaciones en caso se exitosa o se haya producido un error
                if (conMysql.Query(sql) >= 1)
                {
                    MessageBox.Show("!!!... Creación de planilla éxitoso ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se pudo crear planilla ...!!!");
                }

                MostrarNominas();
                   limpiar();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Boton Calcular Nomina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Valicaciones
            if (string.IsNullOrEmpty(textPeriodoCal.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }
            else
            {
                CalcularNomina();
            }
        }

        private void FormNomina_Load(object sender, EventArgs e)
        {
            //txtNombre.Enabled = false;
            //txtApellido.Enabled = false;
           // txtCargo.Enabled = false;

           //  MostrarNominas();

            conMysql.Connect();
            String sql = "select id, concat(id,' - ',mes) mes from mes";
            conMysql.CargarCombo(cb_mesn, sql, "mes", "id");


            String sql2 = "select id, concat(id,' - ',mes) mes from mes where id in (select mes from nominas)";
            conMysql.CargarCombo(cb_mesbus, sql2, "mes", "id");
            conMysql.CargarCombo(cb_mescal, sql2, "mes", "id");

            String sql3 = "select codempleado, concat(codempleado, ' - ', nombre,' ', apellido) nombre from empleados";
            conMysql.CargarCombo(cb_empleados, sql3, "nombre", "codempleado");
        }
    }
}
