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
/// Formulario genear factura de la venta a clientes
/// </summary>
namespace Clave3_Grupo4
{
    public partial class FormFactura : Form
    {
        /// <summary>
        /// Metodo de conexion a la base de datos
        /// </summary>
        Conexion conMysql = new Conexion();
        usuario usuariog = new usuario();
        public FormFactura()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo para agregar productos 
        /// </summary>
        public void addProducto()
        {
            String sql3 = "select valor from productos where id = " + comboBox2.SelectedValue;
            DataRow valor_unit = conMysql.getRow(sql3);

            double valor_producto = 0;
            int cantidad = int.Parse(textBox1.Text);
            var v_unit = (double)valor_unit[0];

            valor_producto = v_unit * cantidad;

            dataGridView1.Rows.Add(comboBox1.SelectedValue, comboBox2.SelectedValue, v_unit, cantidad, valor_producto);
        }
        /// <summary>
        /// Metodo Total Factura genera el total de la factura
        /// </summary>
        public void totalFactura()
        {
            //Variable donde almacenaremos el resultado de la sumatoria.
            double sumatoria = 0;
            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                sumatoria += Convert.ToDouble(row.Cells["Total_producto"].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label
            textBox2.Text = Convert.ToString(sumatoria);
        }
        /// <summary>
        /// Metodo Limpiar Campos
        /// </summary>
        public void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dataGridView1.Rows.Clear();
            //Cree un DataGridView independiente declarando un recuento de columnas.
            dataGridView1.ColumnCount = 5;
            dataGridView1.ColumnHeadersVisible = true;


            // Establece el estilo del encabezado de la columna
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Establece los nombres de los encabezados de las columnas.
            dataGridView1.Columns[0].Name = "Id_Cliente";
            dataGridView1.Columns[1].Name = "Id_Producto";
            dataGridView1.Columns[2].Name = "Valor_Unit.";
            dataGridView1.Columns[3].Name = "Cant.";
            dataGridView1.Columns[4].Name = "Total_producto";

            // Establece el ancho del encabezado de la columna.
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 140;

            //cargar comboBox
            conMysql.Connect();
            String sql = "select id, nombre from clientes";
            String sql2 = "select id,descripcion from productos";
            conMysql.CargarCombo(comboBox1, sql, "nombre", "id");
            conMysql.CargarCombo(comboBox2, sql2, "descripcion", "id");

            String sql3 = "select codempleado, concat(codempleado, ' - ', nombre,' ', apellido) nombre from empleados";
            conMysql.CargarCombo(cb_empleadof, sql3, "nombre", "codempleado");

            cb_empleadof.SelectedValue = usuariog.Usrcodempleado;
        }
        /// <summary>
        /// Metodo Guardar Datos
        /// </summary>
        public void guardar()
        {
            //Validaciones de cada campo
            if (textBox1.Text.Trim() == String.Empty && textBox2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("!!!... Error, los campos no pueden estar vacios ...!!!");
                return;
            }

            if (textBox1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("!!!... Error, el campo cantidad no puede estar vacio ...!!!");
                return;
            }

            if (textBox2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("!!!... Error, el campo total factura no puede estar vacio ...!!!");
                return;
            }

            //dateTimePicker1.Value = DateTime.Now;

            String sql = String.Format("insert into facturas (fecha,cliente_id,valor_total,codempleado)" +
                          " values('{0}','{1}','{2}','{3}')",
                          dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBox1.SelectedValue, textBox2.Text.Trim(), cb_empleadof.SelectedValue);
            try
            {
                if (conMysql.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Registro de Factura éxitoso ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se pudo registar ...!!!");
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataRow busq1 = conMysql.getRow("select max(id) from facturas");

            try
            {
                //Variable del for donde recore los datos y muestra el mensaje en caso sea exitoso
                int contar = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                { 
                        String sql2 = String.Format("insert into factura_detalle (factura_id,producto_id,cantidad,valor_unitario,total_producto)" +
                    " values('{0}','{1}','{2}','{3}','{4}')", busq1[0], Convert.ToInt32(dataGridView1.Rows[i].Cells["Id_Producto"].Value),
                    Convert.ToInt32(dataGridView1.Rows[i].Cells["Cant."].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells["Valor_Unit."].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells["Total_producto"].Value));
                    
                    if (conMysql.Query(sql2) == 1)
                        {
                             contar = contar + 1;
                        }
                        else
                        {
                            contar = contar - 0;
                        }
                 //Mensaje de registro exito de la factura   
                }
                if (contar>=1) { 
                    MessageBox.Show("!!!... Registro de Factura-Detalle éxitoso \n" +
                                           " Número Factura: " + busq1[0] + "\n" +
                                           " Cliente: " + comboBox1.Text + "\n" +
                                           " Total Factura: " + textBox2.Text + "\n" +
                                           " ...!!!");
                }
                else { MessageBox.Show("!!!... ERROR, NO se pudo registar ...!!!"); }
                

                limpiar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Boton limpiar llama metodo limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        private void FormFactura_Load(object sender, EventArgs e)
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnCount = 5;
            dataGridView1.ColumnHeadersVisible = true;

            // Establece el estilo del encabezado de la columna.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Establece los nombres de los encabezados de las columnas
            dataGridView1.Columns[0].Name = "Id_Cliente";
            dataGridView1.Columns[1].Name = "Id_Producto";
            dataGridView1.Columns[2].Name = "Valor_Unit.";
            dataGridView1.Columns[3].Name = "Cant.";
            dataGridView1.Columns[4].Name = "Total_producto";

            // Establece el ancho del encabezado de la columna.
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 140;

            //cargar comboBox
            conMysql.Connect();
            String sql = "select id, nombre from clientes";
            String sql2 = "select id,descripcion from productos";
            String sql3 = "select codempleado, concat(codempleado, ' - ', nombre,' ', apellido) nombre from empleados";
            conMysql.CargarCombo(comboBox1, sql, "nombre", "id");
            conMysql.CargarCombo(comboBox2, sql2, "descripcion", "id");
            conMysql.CargarCombo(cb_empleadof, sql3, "nombre", "codempleado");

            cb_empleadof.SelectedValue = usuariog.Usrcodempleado;


        }
        /// <summary>
        /// Boton agregar Producto nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            addProducto();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Boton que genera el total de la factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            totalFactura();
        }
        /// <summary>
        /// Boton Guardar llaama el metodo guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            guardar();
        }


        private void FormFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.MdiParent = this;
            principal.Show();
        }
    }
}
