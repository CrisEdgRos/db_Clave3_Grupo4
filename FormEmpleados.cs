using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clave3_Grupo4;
/// <summary>
/// Formulario Mantenimiento Empleados
/// </summary>
namespace Clave3_Grupo4
{
    public partial class FormEmpleados : Form
    {
        /// <summary>
        /// Metodo de Conexion a la base de datos mediante la clase Conexion
        /// </summary>
        Conexion conMysql = new Conexion();
        DataRow lstNombre = null;

        public FormEmpleados()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo Guardar
        /// </summary>
        public void Guardar()
        {
            //Validaciones de cada campo del formulario
            if (txtboxa_nombreEmp.Text.Trim() == String.Empty && txtboxa_apellidoEmp.Text.Trim() == String.Empty
                && txtboxa_direccionEmp.Text.Trim() == String.Empty && cbag_cargoEmp.SelectedItem.ToString() == String.Empty)
            {
                MessageBox.Show("!!!... Error, los campos no pueden estar vacios ...!!!");
                return;
            }

            if (txtag_duiEmp.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar el dui");
                return;
            }

            if (txtboxa_nombreEmp.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar nombres");
                return;
            }

            if (txtboxa_apellidoEmp.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar apellidos");
                return;
            }
            
            if (txtboxa_direccionEmp.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresa direccion");
                return;
            }

            if (txtag_telefonoEmp.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresa telefono");
                return;
            }

            if (txtag_cuentabanEmp.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresa cuenta bancaria");
                return;
            }

            if (txtag_salarioEmp.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresa salario");
                return;
            }


            if (txtCorreo.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresa correo");
                return;
            }

            if (cbag_cargoEmp.SelectedItem.ToString() == String.Empty)
            {
                MessageBox.Show("Debes ingresar cargo");
                return;
            }

            empleados empleado2 = new empleados();
            empleado2.Nombres = txtboxa_nombreEmp.Text.Trim();
            empleado2.Cargos = cbag_cargoEmp.SelectedItem.ToString();
            empleado2.Documento = txtag_duiEmp.Text.Trim();
            empleado2.generarCodigoe();

            //Metodo de asignacion en la base de datos segun cada campo en la tabla empleados
            String sql = String.Format("insert into empleados(nombre,apellido,direccion,telefono,cargo,correo,salario,dui,cuentabanco,codempleado,fechaingreso)" +
                          " values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',DATE(NOW()))",
                          txtboxa_nombreEmp.Text.Trim(), txtboxa_apellidoEmp.Text.Trim(), txtboxa_direccionEmp.Text.Trim(), txtag_telefonoEmp.Text.Trim(),
                          cbag_cargoEmp.SelectedValue, txtCorreo.Text.Trim(), txtag_salarioEmp.Text.Trim(), txtag_duiEmp.Text.Trim(), txtag_cuentabanEmp.Text.Trim(),
                          empleado2.codempleado) ;

            try
            {

                if (conMysql.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Registro de empleado éxitoso, el codigo es: "+ empleado2.codempleado + " ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se pudo registar ...!!!");
                }

                Limpiar();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Medoto limpiar campos del formulario
        /// </summary>
        public void Limpiar()
        {
            txtboxa_nombreEmp.Text = "";
            txtboxa_apellidoEmp.Text = "";
            txtboxa_direccionEmp.Text = "";
            cbag_cargoEmp.Text = "";
            txtag_cuentabanEmp.Text = "";
            txtCorreo.Text = "";
            txtag_salarioEmp.Text = "";
            txtag_telefonoEmp.Text = "";
            txtag_duiEmp.Text = "";
            txtboxed_nombreEmp.Text = "";
            txtboxed_apellidoEmp.Text = "";
            txtboxed_direccionEmp.Text = "";
            txtboxed_salarioEmp.Text = "";
            cbc_codigoEmp.Text = "";
            cbed_codigoEmp.Text = "";
            cbe_usuarioEmp.Text = "";
            cbed_cargoEmp.SelectedItem = "";
            litvc_usuarioEmp.Clear();
            litvc_usuarioEmp.View = View.Details;
            litvc_usuarioEmp.GridLines = true;
            litvc_usuarioEmp.FullRowSelect = true;

            //Columnas
            litvc_usuarioEmp.Columns.Add("codigo", 30, HorizontalAlignment.Left);
            litvc_usuarioEmp.Columns.Add("Nombre", 100, HorizontalAlignment.Left);
            litvc_usuarioEmp.Columns.Add("Apellido", 100, HorizontalAlignment.Left);
            litvc_usuarioEmp.Columns.Add("Cargo", 100, HorizontalAlignment.Left);
            litvc_usuarioEmp.Columns.Add("Telefono", 100, HorizontalAlignment.Left);
            litvc_usuarioEmp.Columns.Add("DUI", 100, HorizontalAlignment.Left);           
            litvc_usuarioEmp.Columns.Add("Salario", 100, HorizontalAlignment.Left);

            conMysql.Connect();
            string sql = "select id, codempleado from empleados";
            conMysql.CargarCombo(cbc_codigoEmp, sql, "codempleado", "id");
            conMysql.CargarCombo(cbed_codigoEmp, sql, "codempleado", "id");
            conMysql.CargarCombo(cbe_usuarioEmp, sql, "codempleado", "id");

            String sql2 = "select id, nombre from cargos";
            conMysql.CargarCombo(cbag_cargoEmp, sql2, "nombre", "id");
            conMysql.CargarCombo(cbed_cargoEmp, sql2, "nombre", "id");
        }
        /// <summary>
        /// Metodo Editar Campos
        /// </summary>
        public void Editar()
        {

            try
            {
                //llama datos del tabla empleados y guarda en caso se modifique un campo
                String sql = String.Format("update empleados set nombre='{0}' , apellido='{1}' , direccion ='{2}' , telefono ='{3}', cargo = '{4}', correo = '{5}' , salario = '{6}' , dui = '{7}', cuentabanco = '{8}' where id='{9}' and codempleado ='{10}'",
                txtboxed_nombreEmp.Text.Trim(), txtboxed_apellidoEmp.Text.Trim(), txtboxed_direccionEmp.Text.Trim(), txted_telefonoEmp.Text.Trim(), cbed_cargoEmp.SelectedValue, txtCorreoed_emp.Text.Trim(), txtboxed_salarioEmp.Text.Trim(), 
                txted_duiEmp.Text.Trim(), txted_cuentabancariaEmp.Text.Trim(), cbed_codigoEmp.SelectedValue, txed_codigoEmp.Text.Trim());


                if (conMysql.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Actualización de usuario éxitosa ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se pudo editar el registro ...!!!");
                }

                Limpiar();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Metodo Elimiar, de la tabla empleados el registro completo en caso se elimine todos lo datos de 1 empleado
        /// </summary>
        public void Eliminar()
        {
            String sql = String.Format("delete from empleados where id= '{0}'", cbe_usuarioEmp.SelectedValue);

            if (MessageBox.Show("Seguro que deseas eliminar este empleado?", "Eliminar Empleado",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                try
                {

                    if (conMysql.Query(sql) == 1)
                    {
                        MessageBox.Show("!!!... Empleado Eliminado con éxito ...!!!");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("!!!... ERROR, NO se pudo eliminar ...!!!");
                    }

                    Limpiar();

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        /// <summary>
        /// Agrega los datos a ListView para mostrar los datos de cada empleado consultado desde la tabla empleado
        /// </summary>
        public void AddListView()
        {
            empleados empleado1 = new empleados();

            lstNombre = conMysql.getRow("select * from empleados where id='" + cbc_codigoEmp.SelectedValue + "'");

            //Validacion de empleado eliminado en caso se busque un empleado ya eliminado
            if (cbc_codigoEmp.SelectedValue == null)
            {
                MessageBox.Show("El empleado que intentas mostrar, ya no se encuentra en nuestra base de datos");
            }

            empleado1.Codempleado = lstNombre["codempleado"].ToString();
            empleado1.Nombres = lstNombre["nombre"].ToString();
            empleado1.Apellidos = lstNombre["apellido"].ToString();
            empleado1.Cargos = lstNombre["cargo"].ToString();
            empleado1.Telefono = lstNombre["telefono"].ToString();
            empleado1.Documento = lstNombre["dui"].ToString();
            empleado1.Sueldo = Convert.ToDouble(lstNombre["salario"]);

            ListViewItem lvItem = new ListViewItem();

            lvItem.SubItems[0].Text = empleado1.Codempleado;
            lvItem.SubItems.Add(empleado1.Nombres);
            lvItem.SubItems.Add(empleado1.Apellidos);
            lvItem.SubItems.Add(empleado1.Cargos);
            lvItem.SubItems.Add(empleado1.Telefono);
            lvItem.SubItems.Add(empleado1.Documento);
            lvItem.SubItems.Add(Convert.ToString(empleado1.Sueldo));

            litvc_usuarioEmp.Items.Add(lvItem);

        }
        /// <summary>
        /// Metodo Buscar Empleado con codigo de empleado
        /// </summary>
        public void Buscar()
        {
            String sql = "select * from empleados where id = " + cbed_codigoEmp.SelectedValue;
            DataRow fila = conMysql.getRow(sql);
            if (fila != null)
            {
             
                //Muestra los datos buscado de la tabla en cada texbox
                txtboxed_nombreEmp.Text = fila["nombre"].ToString();
                txtboxed_apellidoEmp.Text = fila["apellido"].ToString();
                txtboxed_direccionEmp.Text = fila["direccion"].ToString();
                txted_telefonoEmp.Text = fila["telefono"].ToString();
                cbed_cargoEmp.SelectedValue = fila["cargo"].ToString();
                txtCorreoed_emp.Text = fila["correo"].ToString();
                txtboxed_salarioEmp.Text = fila["salario"].ToString();
                txted_duiEmp.Text = fila["dui"].ToString();
                txted_cuentabancariaEmp.Text = fila["cuentabanco"].ToString();
                txed_codigoEmp.Text = fila["codempleado"].ToString();
            }
            else
            {
                MessageBox.Show("El empleado que busca no existe");
            }
        }
        /// <summary>
        /// Metodo de inicializacion de componentes de la forma
        /// </summary>
        private void InicializateComponent()
        {
            this.label14 = new System.Windows.Forms.Label();
            this.tc_usuariosEmp = new System.Windows.Forms.TabControl();
            this.tp_consultarEmp = new System.Windows.Forms.TabPage();
            this.groupBox1Emp = new System.Windows.Forms.GroupBox();
            this.btnc_limpiarEmp = new System.Windows.Forms.Button();
            this.litvc_usuarioEmp = new System.Windows.Forms.ListView();
            this.btnc_consultarEmp = new System.Windows.Forms.Button();
            this.cbc_codigoEmp = new System.Windows.Forms.ComboBox();
            this.labelc_codigoEmp = new System.Windows.Forms.Label();
            this.tp_agregarEmp = new System.Windows.Forms.TabPage();
            this.groupBox2Emp = new System.Windows.Forms.GroupBox();
            this.labela_direccionEmp = new System.Windows.Forms.Label();
            this.labela_apellidoEmp = new System.Windows.Forms.Label();
            this.labela_nombreEmp = new System.Windows.Forms.Label();
            this.btna_consultarEmp = new System.Windows.Forms.Button();
            this.cbag_cargoEmp = new System.Windows.Forms.ComboBox();
            this.txtboxa_direccionEmp = new System.Windows.Forms.TextBox();
            this.txtboxa_apellidoEmp = new System.Windows.Forms.TextBox();
            this.txtboxa_nombreEmp = new System.Windows.Forms.TextBox();
            this.btna_guardarEmp = new System.Windows.Forms.Button();
            this.labela_fechaingresoEmp = new System.Windows.Forms.Label();
            this.tp_editarEmp = new System.Windows.Forms.TabPage();
            this.groupBox3Emp = new System.Windows.Forms.GroupBox();
            this.txtboxed_salarioEmp = new System.Windows.Forms.TextBox();
            this.txtboxed_direccionEmp = new System.Windows.Forms.TextBox();
            this.txtboxed_apellidoEmp = new System.Windows.Forms.TextBox();
            this.txtboxed_nombreEmp = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.labeled_cargoEmp = new System.Windows.Forms.Label();
            this.labeled_direccion2Emp = new System.Windows.Forms.Label();
            this.labeled_apellidoEmp = new System.Windows.Forms.Label();
            this.labeled_nombreEmp = new System.Windows.Forms.Label();
            this.btned_consultarEmp = new System.Windows.Forms.Button();
            this.cbed_codigoEmp = new System.Windows.Forms.ComboBox();
            this.labeled_codigoEmp = new System.Windows.Forms.Label();
            this.tp_eliminarEmp = new System.Windows.Forms.TabPage();
            this.groupBox4Emp = new System.Windows.Forms.GroupBox();
            this.btne_eliminarEmp = new System.Windows.Forms.Button();
            this.cbe_usuarioEmp = new System.Windows.Forms.ComboBox();
            this.labele_usuarioEmp = new System.Windows.Forms.Label();
            this.cbed_cargoEmp = new System.Windows.Forms.ComboBox();
            this.labeled_departamentoEmp = new System.Windows.Forms.Label();
            this.tc_usuariosEmp.SuspendLayout();
            this.tp_consultarEmp.SuspendLayout();
            this.groupBox1Emp.SuspendLayout();
            this.tp_agregarEmp.SuspendLayout();
            this.groupBox2Emp.SuspendLayout();
            this.tp_editarEmp.SuspendLayout();
            this.groupBox3Emp.SuspendLayout();
            this.tp_eliminarEmp.SuspendLayout();
            this.groupBox4Emp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(47, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(532, 34);
            this.label14.TabIndex = 3;
            this.label14.Text = "MANTENIMIENTO DE EMPLEADOS";
            // 
            // tc_usuarios
            // 
            this.tc_usuariosEmp.Controls.Add(this.tp_consultarEmp);
            this.tc_usuariosEmp.Controls.Add(this.tp_agregarEmp);
            this.tc_usuariosEmp.Controls.Add(this.tp_editarEmp);
            this.tc_usuariosEmp.Controls.Add(this.tp_eliminarEmp);
            this.tc_usuariosEmp.Location = new System.Drawing.Point(19, 51);
            this.tc_usuariosEmp.Name = "tc_usuarios";
            this.tc_usuariosEmp.SelectedIndex = 0;
            this.tc_usuariosEmp.Size = new System.Drawing.Size(576, 395);
            this.tc_usuariosEmp.TabIndex = 2;
            // 
            // tp_consultar
            // 
            this.tp_consultarEmp.Controls.Add(this.groupBox1Emp);
            this.tp_consultarEmp.Location = new System.Drawing.Point(4, 22);
            this.tp_consultarEmp.Name = "tp_consultar";
            this.tp_consultarEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tp_consultarEmp.Size = new System.Drawing.Size(568, 369);
            this.tp_consultarEmp.TabIndex = 0;
            this.tp_consultarEmp.Text = "Consultar";
            this.tp_consultarEmp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1Emp.Controls.Add(this.btnc_limpiarEmp);
            this.groupBox1Emp.Controls.Add(this.litvc_usuarioEmp);
            this.groupBox1Emp.Controls.Add(this.btnc_consultarEmp);
            this.groupBox1Emp.Controls.Add(this.cbc_codigoEmp);
            this.groupBox1Emp.Controls.Add(this.labelc_codigoEmp);
            this.groupBox1Emp.Location = new System.Drawing.Point(3, 7);
            this.groupBox1Emp.Name = "groupBox1Emp";
            this.groupBox1Emp.Size = new System.Drawing.Size(559, 359);
            this.groupBox1Emp.TabIndex = 0;
            this.groupBox1Emp.TabStop = false;
            // 
            // btnc_limpiar
            // 
            this.btnc_limpiarEmp.Location = new System.Drawing.Point(358, 77);
            this.btnc_limpiarEmp.Name = "btnc_limpiarEmp";
            this.btnc_limpiarEmp.Size = new System.Drawing.Size(75, 23);
            this.btnc_limpiarEmp.TabIndex = 4;
            this.btnc_limpiarEmp.Text = "Limpiar";
            this.btnc_limpiarEmp.UseVisualStyleBackColor = true;
            this.btnc_limpiarEmp.Click += new System.EventHandler(this.btnc_limpiar_Click);
            // 
            // litvc_usuario
            // 
            this.litvc_usuarioEmp.HideSelection = false;
            this.litvc_usuarioEmp.Location = new System.Drawing.Point(7, 120);
            this.litvc_usuarioEmp.Name = "litvc_usuarioEmp";
            this.litvc_usuarioEmp.Size = new System.Drawing.Size(546, 232);
            this.litvc_usuarioEmp.TabIndex = 3;
            this.litvc_usuarioEmp.UseCompatibleStateImageBehavior = false;
            // 
            // btnc_consultar
            // 
            this.btnc_consultarEmp.Location = new System.Drawing.Point(152, 77);
            this.btnc_consultarEmp.Name = "btnc_consultarEmp";
            this.btnc_consultarEmp.Size = new System.Drawing.Size(75, 23);
            this.btnc_consultarEmp.TabIndex = 2;
            this.btnc_consultarEmp.Text = "Consultar";
            this.btnc_consultarEmp.UseVisualStyleBackColor = true;
            this.btnc_consultarEmp.Click += new System.EventHandler(this.btnc_consultar_Click);
            // 
            // cbc_usuario
            // 
            this.cbc_codigoEmp.FormattingEnabled = true;
            this.cbc_codigoEmp.Location = new System.Drawing.Point(95, 29);
            this.cbc_codigoEmp.Name = "cbc_codigoEmp";
            this.cbc_codigoEmp.Size = new System.Drawing.Size(253, 21);
            this.cbc_codigoEmp.TabIndex = 1;
            this.cbc_codigoEmp.Text = "-- Seleccione --";
            // 
            // labelc_usuario
            // 
            this.labelc_codigoEmp.AutoSize = true;
            this.labelc_codigoEmp.Location = new System.Drawing.Point(27, 33);
            this.labelc_codigoEmp.Name = "labelc_codigoEmp";
            this.labelc_codigoEmp.Size = new System.Drawing.Size(43, 13);
            this.labelc_codigoEmp.TabIndex = 0;
            this.labelc_codigoEmp.Text = "Codigo";
            // 
            // tp_agregar
            // 
            this.tp_agregarEmp.Controls.Add(this.groupBox2Emp);
            this.tp_agregarEmp.Location = new System.Drawing.Point(4, 22);
            this.tp_agregarEmp.Name = "tp_agregarEmp";
            this.tp_agregarEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tp_agregarEmp.Size = new System.Drawing.Size(568, 369);
            this.tp_agregarEmp.TabIndex = 1;
            this.tp_agregarEmp.Text = "Agregar";
            this.tp_agregarEmp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2Emp.Controls.Add(this.labela_direccionEmp);
            this.groupBox2Emp.Controls.Add(this.labela_apellidoEmp);
            this.groupBox2Emp.Controls.Add(this.labela_nombreEmp);
            this.groupBox2Emp.Controls.Add(this.btna_consultarEmp);
            this.groupBox2Emp.Controls.Add(this.cbag_cargoEmp);
            this.groupBox2Emp.Controls.Add(this.txtboxa_direccionEmp);
            this.groupBox2Emp.Controls.Add(this.txtboxa_apellidoEmp);
            this.groupBox2Emp.Controls.Add(this.txtboxa_nombreEmp);
            this.groupBox2Emp.Controls.Add(this.btna_guardarEmp);
            this.groupBox2Emp.Controls.Add(this.labela_fechaingresoEmp);
            this.groupBox2Emp.Location = new System.Drawing.Point(6, 6);
            this.groupBox2Emp.Name = "groupBox2Emp";
            this.groupBox2Emp.Size = new System.Drawing.Size(556, 357);
            this.groupBox2Emp.TabIndex = 0;
            this.groupBox2Emp.TabStop = false;
            // 
            // labela_usuario
            // 
            this.labela_direccionEmp.AutoSize = true;
            this.labela_direccionEmp.Location = new System.Drawing.Point(12, 125);
            this.labela_direccionEmp.Name = "labela_usuarioEmp";
            this.labela_direccionEmp.Size = new System.Drawing.Size(43, 13);
            this.labela_direccionEmp.TabIndex = 15;
            this.labela_direccionEmp.Text = "Usuario";
            // 
            // labela_apellido
            // 
            this.labela_apellidoEmp.AutoSize = true;
            this.labela_apellidoEmp.Location = new System.Drawing.Point(11, 81);
            this.labela_apellidoEmp.Name = "labela_apellidoEmp";
            this.labela_apellidoEmp.Size = new System.Drawing.Size(44, 13);
            this.labela_apellidoEmp.TabIndex = 14;
            this.labela_apellidoEmp.Text = "Apellido";
            // 
            // labela_nombre
            // 
            this.labela_nombreEmp.AutoSize = true;
            this.labela_nombreEmp.Location = new System.Drawing.Point(11, 34);
            this.labela_nombreEmp.Name = "labela_nombreEmp";
            this.labela_nombreEmp.Size = new System.Drawing.Size(44, 13);
            this.labela_nombreEmp.TabIndex = 13;
            this.labela_nombreEmp.Text = "Nombre";
            // 
            // btna_consultar
            // 
            this.btna_consultarEmp.Location = new System.Drawing.Point(348, 239);
            this.btna_consultarEmp.Name = "btna_consultarEmp";
            this.btna_consultarEmp.Size = new System.Drawing.Size(131, 23);
            this.btna_consultarEmp.TabIndex = 11;
            this.btna_consultarEmp.Text = "Limpiar";
            this.btna_consultarEmp.UseVisualStyleBackColor = true;
            this.btna_consultarEmp.Click += new System.EventHandler(this.btna_consultar_Click);
            // 
            // txtboxa_clave
            // 
            this.cbag_cargoEmp.Location = new System.Drawing.Point(89, 162);
            this.cbag_cargoEmp.MaxLength = 60;
            this.cbag_cargoEmp.Name = "txtboxa_clave";
            this.cbag_cargoEmp.Size = new System.Drawing.Size(447, 20);
            this.cbag_cargoEmp.TabIndex = 10;
            // 
            // txtboxa_usuario
            // 
            this.txtboxa_direccionEmp.Location = new System.Drawing.Point(89, 118);
            this.txtboxa_direccionEmp.MaxLength = 15;
            this.txtboxa_direccionEmp.Name = "txtboxa_usuario";
            this.txtboxa_direccionEmp.Size = new System.Drawing.Size(447, 20);
            this.txtboxa_direccionEmp.TabIndex = 9;
            // 
            // txtboxa_apellido
            // 
            this.txtboxa_apellidoEmp.Location = new System.Drawing.Point(89, 74);
            this.txtboxa_apellidoEmp.MaxLength = 50;
            this.txtboxa_apellidoEmp.Name = "txtboxa_apellido";
            this.txtboxa_apellidoEmp.Size = new System.Drawing.Size(447, 20);
            this.txtboxa_apellidoEmp.TabIndex = 8;
            // 
            // txtboxa_nombre
            // 
            this.txtboxa_nombreEmp.Location = new System.Drawing.Point(89, 31);
            this.txtboxa_nombreEmp.MaxLength = 60;
            this.txtboxa_nombreEmp.Name = "txtboxa_nombreEmp";
            this.txtboxa_nombreEmp.Size = new System.Drawing.Size(447, 20);
            this.txtboxa_nombreEmp.TabIndex = 7;
            // 
            // btna_guardar
            // 
            this.btna_guardarEmp.Location = new System.Drawing.Point(71, 239);
            this.btna_guardarEmp.Name = "btna_guardarEmp";
            this.btna_guardarEmp.Size = new System.Drawing.Size(133, 23);
            this.btna_guardarEmp.TabIndex = 5;
            this.btna_guardarEmp.Text = "Guardar";
            this.btna_guardarEmp.UseVisualStyleBackColor = true;
            this.btna_guardarEmp.Click += new System.EventHandler(this.btna_guardar_Click);
            // 
            // labela_clave
            // 
            this.labela_fechaingresoEmp.AutoSize = true;
            this.labela_fechaingresoEmp.Location = new System.Drawing.Point(12, 169);
            this.labela_fechaingresoEmp.Name = "labela_claveEmp";
            this.labela_fechaingresoEmp.Size = new System.Drawing.Size(61, 13);
            this.labela_fechaingresoEmp.TabIndex = 4;
            this.labela_fechaingresoEmp.Text = "Contraseña";
            // 
            // tp_editar
            // 
            this.tp_editarEmp.Controls.Add(this.groupBox3Emp);
            this.tp_editarEmp.Location = new System.Drawing.Point(4, 22);
            this.tp_editarEmp.Name = "tp_editarEmp";
            this.tp_editarEmp.Size = new System.Drawing.Size(568, 369);
            this.tp_editarEmp.TabIndex = 2;
            this.tp_editarEmp.Text = "Editar";
            this.tp_editarEmp.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3Emp.Controls.Add(this.labeled_departamentoEmp);
            this.groupBox3Emp.Controls.Add(this.cbed_cargoEmp);
            this.groupBox3Emp.Controls.Add(this.txtboxed_salarioEmp);
            this.groupBox3Emp.Controls.Add(this.txtboxed_direccionEmp);
            this.groupBox3Emp.Controls.Add(this.txtboxed_apellidoEmp);
            this.groupBox3Emp.Controls.Add(this.txtboxed_nombreEmp);
            this.groupBox3Emp.Controls.Add(this.btn_actualizar);
            this.groupBox3Emp.Controls.Add(this.labeled_cargoEmp);
            this.groupBox3Emp.Controls.Add(this.labeled_direccion2Emp);
            this.groupBox3Emp.Controls.Add(this.labeled_apellidoEmp);
            this.groupBox3Emp.Controls.Add(this.labeled_nombreEmp);
            this.groupBox3Emp.Controls.Add(this.btned_consultarEmp);
            this.groupBox3Emp.Controls.Add(this.cbed_codigoEmp);
            this.groupBox3Emp.Controls.Add(this.labeled_codigoEmp);
            this.groupBox3Emp.Location = new System.Drawing.Point(5, 3);
            this.groupBox3Emp.Name = "groupBox3Emp";
            this.groupBox3Emp.Size = new System.Drawing.Size(560, 363);
            this.groupBox3Emp.TabIndex = 0;
            this.groupBox3Emp.TabStop = false;
            // 
            // txtboxed_clave
            // 
            this.txtboxed_salarioEmp.Location = new System.Drawing.Point(90, 237);
            this.txtboxed_salarioEmp.Name = "txtboxed_salarioEmp";
            this.txtboxed_salarioEmp.Size = new System.Drawing.Size(444, 20);
            this.txtboxed_salarioEmp.TabIndex = 12;
            // 
            // txtboxed_usuario
            // 
            this.txtboxed_direccionEmp.Location = new System.Drawing.Point(90, 196);
            this.txtboxed_direccionEmp.Name = "txtboxed_direccionEmp";
            this.txtboxed_direccionEmp.Size = new System.Drawing.Size(444, 20);
            this.txtboxed_direccionEmp.TabIndex = 11;
            // 
            // txtboxed_apellido
            // 
            this.txtboxed_apellidoEmp.Location = new System.Drawing.Point(90, 151);
            this.txtboxed_apellidoEmp.Name = "txtboxed_apellidoEmp";
            this.txtboxed_apellidoEmp.Size = new System.Drawing.Size(444, 20);
            this.txtboxed_apellidoEmp.TabIndex = 10;
            // 
            // txtboxed_nombre
            // 
            this.txtboxed_nombreEmp.Location = new System.Drawing.Point(90, 102);
            this.txtboxed_nombreEmp.Name = "txtboxed_nombreEmp";
            this.txtboxed_nombreEmp.Size = new System.Drawing.Size(444, 20);
            this.txtboxed_nombreEmp.TabIndex = 9;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(208, 317);
            this.btn_actualizar.Name = "btn_actualizarEmp";
            this.btn_actualizar.Size = new System.Drawing.Size(116, 23);
            this.btn_actualizar.TabIndex = 8;
            this.btn_actualizar.Text = "Guardar Cambios";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // labeled_clave
            // 
            this.labeled_cargoEmp.AutoSize = true;
            this.labeled_cargoEmp.Location = new System.Drawing.Point(16, 237);
            this.labeled_cargoEmp.Name = "labeled_claveEmp";
            this.labeled_cargoEmp.Size = new System.Drawing.Size(61, 13);
            this.labeled_cargoEmp.TabIndex = 6;
            this.labeled_cargoEmp.Text = "Cargo";
            // 
            // labeled_usuario2
            // 
            this.labeled_direccion2Emp.AutoSize = true;
            this.labeled_direccion2Emp.Location = new System.Drawing.Point(16, 196);
            this.labeled_direccion2Emp.Name = "labeled_codigo2EMp";
            this.labeled_direccion2Emp.Size = new System.Drawing.Size(43, 13);
            this.labeled_direccion2Emp.TabIndex = 5;
            this.labeled_direccion2Emp.Text = "codigo";
            // 
            // labeled_apellido
            // 
            this.labeled_apellidoEmp.AutoSize = true;
            this.labeled_apellidoEmp.Location = new System.Drawing.Point(16, 151);
            this.labeled_apellidoEmp.Name = "labeled_apellidoEmp";
            this.labeled_apellidoEmp.Size = new System.Drawing.Size(44, 13);
            this.labeled_apellidoEmp.TabIndex = 4;
            this.labeled_apellidoEmp.Text = "Apellido";
            // 
            // labeled_nombre
            // 
            this.labeled_nombreEmp.AutoSize = true;
            this.labeled_nombreEmp.Location = new System.Drawing.Point(16, 102);
            this.labeled_nombreEmp.Name = "labeled_nombreEmp";
            this.labeled_nombreEmp.Size = new System.Drawing.Size(44, 13);
            this.labeled_nombreEmp.TabIndex = 3;
            this.labeled_nombreEmp.Text = "Nombre";
            // 
            // btned_consultar
            // 
            this.btned_consultarEmp.Location = new System.Drawing.Point(197, 58);
            this.btned_consultarEmp.Name = "btned_consultarEmp";
            this.btned_consultarEmp.Size = new System.Drawing.Size(127, 23);
            this.btned_consultarEmp.TabIndex = 2;
            this.btned_consultarEmp.Text = "Consultar";
            this.btned_consultarEmp.UseVisualStyleBackColor = true;
            this.btned_consultarEmp.Click += new System.EventHandler(this.btned_consultar_Click);
            // 
            // cbed_usuario
            // 
            this.cbed_codigoEmp.FormattingEnabled = true;
            this.cbed_codigoEmp.Location = new System.Drawing.Point(90, 22);
            this.cbed_codigoEmp.Name = "cbed_usuarioEmp";
            this.cbed_codigoEmp.Size = new System.Drawing.Size(444, 21);
            this.cbed_codigoEmp.TabIndex = 1;
            this.cbed_codigoEmp.Text = "-- Seleccione --";
            // 
            // labeled_usuario
            // 
            this.labeled_codigoEmp.AutoSize = true;
            this.labeled_codigoEmp.Location = new System.Drawing.Point(13, 27);
            this.labeled_codigoEmp.Name = "labeled_usuarioEmp";
            this.labeled_codigoEmp.Size = new System.Drawing.Size(43, 13);
            this.labeled_codigoEmp.TabIndex = 0;
            this.labeled_codigoEmp.Text = "codigo";
            // 
            // tp_eliminar
            // 
            this.tp_eliminarEmp.Controls.Add(this.groupBox4Emp);
            this.tp_eliminarEmp.Location = new System.Drawing.Point(4, 22);
            this.tp_eliminarEmp.Name = "tp_eliminarEmp";
            this.tp_eliminarEmp.Size = new System.Drawing.Size(568, 369);
            this.tp_eliminarEmp.TabIndex = 3;
            this.tp_eliminarEmp.Text = "Eliminar";
            this.tp_eliminarEmp.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4Emp.Controls.Add(this.btne_eliminarEmp);
            this.groupBox4Emp.Controls.Add(this.cbe_usuarioEmp);
            this.groupBox4Emp.Controls.Add(this.labele_usuarioEmp);
            this.groupBox4Emp.Location = new System.Drawing.Point(4, 3);
            this.groupBox4Emp.Name = "groupBox4Emp";
            this.groupBox4Emp.Size = new System.Drawing.Size(450, 190);
            this.groupBox4Emp.TabIndex = 0;
            this.groupBox4Emp.TabStop = false;
            // 
            // btne_eliminar
            // 
            this.btne_eliminarEmp.Location = new System.Drawing.Point(174, 115);
            this.btne_eliminarEmp.Name = "btne_eliminarEmp";
            this.btne_eliminarEmp.Size = new System.Drawing.Size(75, 23);
            this.btne_eliminarEmp.TabIndex = 5;
            this.btne_eliminarEmp.Text = "Eliminar";
            this.btne_eliminarEmp.UseVisualStyleBackColor = true;
            this.btne_eliminarEmp.Click += new System.EventHandler(this.btne_eliminarEmp_Click);
            // 
            // cbe_usuario
            // 
            this.cbe_usuarioEmp.FormattingEnabled = true;
            this.cbe_usuarioEmp.Location = new System.Drawing.Point(118, 53);
            this.cbe_usuarioEmp.Name = "cbe_usuarioEMp";
            this.cbe_usuarioEmp.Size = new System.Drawing.Size(285, 21);
            this.cbe_usuarioEmp.TabIndex = 4;
            this.cbe_usuarioEmp.Text = " -- Seleccione --";
            // 
            // labele_usuario
            // 
            this.labele_usuarioEmp.AutoSize = true;
            this.labele_usuarioEmp.Location = new System.Drawing.Point(47, 56);
            this.labele_usuarioEmp.Name = "labele_usuarioEmp";
            this.labele_usuarioEmp.Size = new System.Drawing.Size(43, 13);
            this.labele_usuarioEmp.TabIndex = 3;
            this.labele_usuarioEmp.Text = "Usuario";
            // 
            // cbed_estado
            // 
            this.cbed_cargoEmp.FormattingEnabled = true;
            this.cbed_cargoEmp.Items.AddRange(new object[] {
            "Administrativo",
            "Ventas"});
            this.cbed_cargoEmp.Location = new System.Drawing.Point(90, 280);
            this.cbed_cargoEmp.Name = "cbed_estado";
            this.cbed_cargoEmp.Size = new System.Drawing.Size(121, 21);
            this.cbed_cargoEmp.TabIndex = 13;
            // 
            // labeled_estado
            // 
            this.labeled_departamentoEmp.AutoSize = true;
            this.labeled_departamentoEmp.Location = new System.Drawing.Point(19, 287);
            this.labeled_departamentoEmp.Name = "labeled_estadoEmp";
            this.labeled_departamentoEmp.Size = new System.Drawing.Size(40, 13);
            this.labeled_departamentoEmp.TabIndex = 14;
            this.labeled_departamentoEmp.Text = "Estado";
            // 
            // FormUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(614, 471);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tc_usuariosEmp);
            this.Name = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.tc_usuariosEmp.ResumeLayout(false);
            this.tp_consultarEmp.ResumeLayout(false);
            this.groupBox1Emp.ResumeLayout(false);
            this.groupBox1Emp.PerformLayout();
            this.tp_agregarEmp.ResumeLayout(false);
            this.groupBox2Emp.ResumeLayout(false);
            this.groupBox2Emp.PerformLayout();
            this.tp_editarEmp.ResumeLayout(false);
            this.groupBox3Emp.ResumeLayout(false);
            this.groupBox3Emp.PerformLayout();
            this.tp_eliminarEmp.ResumeLayout(false);
            this.groupBox4Emp.ResumeLayout(false);
            this.groupBox4Emp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /// <summary>
        /// Boton Consultar llama el metodo consultar y agrega los datos al ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnc_consultar_Click(object sender, EventArgs e)
        {
            AddListView();
        }
        /// <summary>
        /// Bototn Limpiar llama metodo limpiar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnc_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Boton Guardar llama metodo guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btna_guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        /// <summary>
        /// Boton Limpiar llama metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btna_consultar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Boton Consultar llama metodo Buscar de la tabla empleados en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btned_consultar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        /// <summary>
        /// Boton Actualizar llama el metodo Editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            //Propiedades del ListView
            litvc_usuarioEmp.View = View.Details;
            litvc_usuarioEmp.GridLines = true;
            litvc_usuarioEmp.FullRowSelect = true;

            

            //Columnas
            litvc_usuarioEmp.Columns.Add("codigo", 30, HorizontalAlignment.Left);
            litvc_usuarioEmp.Columns.Add("Nombre", 100, HorizontalAlignment.Left);
            litvc_usuarioEmp.Columns.Add("Apellido", 100, HorizontalAlignment.Left);
            litvc_usuarioEmp.Columns.Add("Cargo", 100, HorizontalAlignment.Left);
            litvc_usuarioEmp.Columns.Add("Telefono", 100, HorizontalAlignment.Left);
            litvc_usuarioEmp.Columns.Add("DUI", 100, HorizontalAlignment.Left);
            litvc_usuarioEmp.Columns.Add("Salario", 100, HorizontalAlignment.Left);
            
            
            //llama el codigo de empleado de la tabla empleados
            conMysql.Connect();
            String sql = "select id, codempleado from empleados";
            conMysql.CargarCombo(cbc_codigoEmp, sql, "codempleado", "id");
            conMysql.CargarCombo(cbed_codigoEmp, sql, "codempleado", "id");
            conMysql.CargarCombo(cbe_usuarioEmp, sql, "codempleado", "id");


            String sql2 = "select id, nombre from cargos";
            conMysql.CargarCombo(cbag_cargoEmp, sql2, "nombre", "id");
            conMysql.CargarCombo(cbed_cargoEmp, sql2, "nombre", "id");
            
        }
        /// <summary>
        /// Boton Eliminar Empleado llama el metodo eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btne_eliminarEmp_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void txtag_codigoEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1Emp_Enter(object sender, EventArgs e)
        {

        }
    }
}
