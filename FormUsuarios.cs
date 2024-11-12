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
/// Formulario de mantenimiento de usuarios
/// </summary>
namespace Clave3_Grupo4
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormUsuarios : Form
    {
        /// <summary>
        /// Metodo de conxion a la base de datos
        /// </summary>
        Conexion conMysql = new Conexion();
        DataRow lstNombre = null;

        public FormUsuarios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo Guardar
        /// </summary>
        public void guardar()
        {
            if (txtboxa_nombre.Text.Trim() == String.Empty && txtboxa_apellido.Text.Trim() == String.Empty
                && txtboxa_usuario.Text.Trim() == String.Empty && txtboxa_clave.Text.Trim() == String.Empty)
            {
                MessageBox.Show("!!!... Error, los campos no pueden estar vacios ...!!!");
                return;
            }
            //Validaciones de cada campo esten llenos
            if (txtboxa_nombre.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar nombres");
                return;
            }

            if (txtboxa_apellido.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar apellidos");
                return;
            }

            if (txtboxa_usuario.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresa usuario");
                return;
            }

            if (txtboxa_clave.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar contraseña");
                return;
            }

            String sql = String.Format("insert into usuarios(nombre,apellido,usuario,clave,fecha_creacion,codempleado)" +
                          " values('{0}','{1}','{2}',aes_encrypt('{2}','{3}'),DATE(NOW()),'{4}')",
                          txtboxa_nombre.Text.Trim(), txtboxa_apellido.Text.Trim(), txtboxa_usuario.Text.Trim(), txtboxa_clave.Text.Trim(), cb_codempleadosa.SelectedValue);

            try
            {
                //Validacion de registro en la base de datos
                if (conMysql.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Registro de usuario éxitoso ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se pudo registar ...!!!");
                }

                limpiar();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Metodo Limpiar Campos
        /// </summary>
        public void limpiar()
        {
            txtboxa_nombre.Text = "";
            txtboxa_apellido.Text = "";
            txtboxa_usuario.Text = "";
            txtboxa_clave.Text = "";
            txtboxa_clave.Text = "";
            txtboxed_nombre.Text = "";
            txtboxed_apellido.Text = "";
            txtboxed_usuario.Text = "";
            txtboxed_clave.Text = "";
            cbc_usuario.Text = "";
            cbed_usuario.Text = "";
            cbe_usuario.Text = "";
            cbed_estado.SelectedItem = "";
            litvc_usuario.Clear();
            litvc_usuario.View = View.Details;
            litvc_usuario.GridLines = true;
            litvc_usuario.FullRowSelect = true;

            //Columnas
            litvc_usuario.Columns.Add("Id", 30, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("Nombre", 70, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("Apellido", 150, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("Usuario", 50, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("estado", 50, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("fecha_creacion", 50, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("Código Empleado", 50, HorizontalAlignment.Left);
            //Conexion columna usuario a la tabla usuarios
            conMysql.Connect();
            String sql = "select id, usuario from usuarios";
            conMysql.CargarCombo(cbc_usuario, sql, "usuario", "id");
            conMysql.CargarCombo(cbed_usuario, sql, "usuario", "id");
            conMysql.CargarCombo(cbe_usuario, sql, "usuario", "id");

            String sql2 = "select codempleado, concat(codempleado, ' - ', nombre,' ', apellido) nombre from empleados";
            conMysql.CargarCombo(cb_codempleadosa, sql2, "nombre", "codempleado");
            conMysql.CargarCombo(cb_codempleadoed, sql2, "nombre", "codempleado");
        }
        /// <summary>
        /// Metodo Editar
        /// </summary>
        public void editar()
        {
            String sql = String.Format("update usuarios set nombre='{0}', apellido='{1}',usuario='{2}', clave=aes_encrypt('{2}','{3}'), estado='{4}', codempleado='{5}' where id='{6}' and usuario='{7}'",
                          txtboxed_nombre.Text.Trim(), txtboxed_apellido.Text.Trim(), txtboxed_usuario.Text.Trim(), txtboxed_clave.Text.Trim(), cbed_estado.SelectedItem, cb_codempleadoed.SelectedValue, cbed_usuario.SelectedValue, txtboxed_usuario.Text.Trim());
            try
            {
                //Validacion de actualizacion de usuario
                if (conMysql.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Actualización de usuario éxitosa ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se pudo editar el registro ...!!!");
                }

                limpiar();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Metodo Eliminar
        /// </summary>
        public void eliminar()
        {
            String sql = String.Format("delete from usuarios where id= '{0}'", cbe_usuario.SelectedValue);

            if (MessageBox.Show("Seguro que deseas eliminar este usuario?", "Eliminar Usuario",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                try
                {
                    //Validacion de la eliminacion del usuario
                    if (conMysql.Query(sql) == 1)
                    {
                        MessageBox.Show("!!!... Usuario Eliminado con éxito ...!!!");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("!!!... ERROR, NO se pudo eliminar ...!!!");
                    }

                    limpiar();

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        /// <summary>
        /// Metodo Mostrar en Listview
        /// </summary>
        public void addListView()
        {

            lstNombre = conMysql.getRow("select * from usuarios where id='" + cbc_usuario.SelectedValue + "'");

            if (cbc_usuario.SelectedValue == null)
            {
                //Validacion de usuario en el caso no exista en la base
                MessageBox.Show("El usuario que intentas mostrar, ya no se encuentra en nuestra base de datos");
            }
            //Carga los datos en el listView
            ListViewItem lvItem = new ListViewItem();

            lvItem.SubItems[0].Text = lstNombre[0].ToString();
            lvItem.SubItems.Add(lstNombre[1].ToString());
            lvItem.SubItems.Add(lstNombre[2].ToString());
            lvItem.SubItems.Add(lstNombre[3].ToString());
            lvItem.SubItems.Add(lstNombre[5].ToString());
            lvItem.SubItems.Add(lstNombre[6].ToString());
            lvItem.SubItems.Add(lstNombre[7].ToString());

            litvc_usuario.Items.Add(lvItem);

        }
        /// <summary>
        /// Metodo Buscar en la tabla usuarios de la base de datos
        /// </summary>
        public void buscar()
        {
            String sql = "select * from usuarios where id = " + cbed_usuario.SelectedValue;
            DataRow fila = conMysql.getRow(sql);
            if (fila != null)
            {
                txtboxed_nombre.Text = fila["nombre"].ToString();
                txtboxed_apellido.Text = fila["apellido"].ToString();
                txtboxed_usuario.Text = fila["usuario"].ToString();
                txtboxed_clave.Text = "";
                cbed_estado.SelectedItem = fila["estado"].ToString();
                cb_codempleadoed.SelectedValue = fila["codempleado"].ToString();
            }
            else
            {
                //Validacion del usuario en caso no exista
                MessageBox.Show("El usuario que busca no existe");
            }
        }
        /// <summary>
        /// Inicializate Componentes
        /// </summary>
        private void InitializeComponent()
        {
            this.label14 = new System.Windows.Forms.Label();
            this.tc_usuarios = new System.Windows.Forms.TabControl();
            this.tp_consultar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnc_limpiar = new System.Windows.Forms.Button();
            this.litvc_usuario = new System.Windows.Forms.ListView();
            this.btnc_consultar = new System.Windows.Forms.Button();
            this.cbc_usuario = new System.Windows.Forms.ComboBox();
            this.labelc_usuario = new System.Windows.Forms.Label();
            this.tp_agregar = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labela_usuario = new System.Windows.Forms.Label();
            this.labela_apellido = new System.Windows.Forms.Label();
            this.labela_nombre = new System.Windows.Forms.Label();
            this.btna_consultar = new System.Windows.Forms.Button();
            this.txtboxa_clave = new System.Windows.Forms.TextBox();
            this.txtboxa_usuario = new System.Windows.Forms.TextBox();
            this.txtboxa_apellido = new System.Windows.Forms.TextBox();
            this.txtboxa_nombre = new System.Windows.Forms.TextBox();
            this.btna_guardar = new System.Windows.Forms.Button();
            this.labela_clave = new System.Windows.Forms.Label();
            this.tp_editar = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labeled_estado = new System.Windows.Forms.Label();
            this.cbed_estado = new System.Windows.Forms.ComboBox();
            this.txtboxed_clave = new System.Windows.Forms.TextBox();
            this.txtboxed_usuario = new System.Windows.Forms.TextBox();
            this.txtboxed_apellido = new System.Windows.Forms.TextBox();
            this.txtboxed_nombre = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.labeled_clave = new System.Windows.Forms.Label();
            this.labeled_usuario2 = new System.Windows.Forms.Label();
            this.labeled_apellido = new System.Windows.Forms.Label();
            this.labeled_nombre = new System.Windows.Forms.Label();
            this.btned_consultar = new System.Windows.Forms.Button();
            this.cbed_usuario = new System.Windows.Forms.ComboBox();
            this.labeled_usuario = new System.Windows.Forms.Label();
            this.tp_eliminar = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btne_eliminar = new System.Windows.Forms.Button();
            this.cbe_usuario = new System.Windows.Forms.ComboBox();
            this.labele_usuario = new System.Windows.Forms.Label();
            this.cb_codempleadosa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_codempleadoed = new System.Windows.Forms.ComboBox();
            this.tc_usuarios.SuspendLayout();
            this.tp_consultar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tp_agregar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tp_editar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tp_eliminar.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(71, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(456, 29);
            this.label14.TabIndex = 3;
            this.label14.Text = "MANTENIMIENTO DE USUARIOS";
            // 
            // tc_usuarios
            // 
            this.tc_usuarios.Controls.Add(this.tp_consultar);
            this.tc_usuarios.Controls.Add(this.tp_agregar);
            this.tc_usuarios.Controls.Add(this.tp_editar);
            this.tc_usuarios.Controls.Add(this.tp_eliminar);
            this.tc_usuarios.Location = new System.Drawing.Point(19, 51);
            this.tc_usuarios.Name = "tc_usuarios";
            this.tc_usuarios.SelectedIndex = 0;
            this.tc_usuarios.Size = new System.Drawing.Size(576, 395);
            this.tc_usuarios.TabIndex = 2;
            // 
            // tp_consultar
            // 
            this.tp_consultar.Controls.Add(this.groupBox1);
            this.tp_consultar.Location = new System.Drawing.Point(4, 22);
            this.tp_consultar.Name = "tp_consultar";
            this.tp_consultar.Padding = new System.Windows.Forms.Padding(3);
            this.tp_consultar.Size = new System.Drawing.Size(568, 369);
            this.tp_consultar.TabIndex = 0;
            this.tp_consultar.Text = "Consultar";
            this.tp_consultar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.btnc_limpiar);
            this.groupBox1.Controls.Add(this.litvc_usuario);
            this.groupBox1.Controls.Add(this.btnc_consultar);
            this.groupBox1.Controls.Add(this.cbc_usuario);
            this.groupBox1.Controls.Add(this.labelc_usuario);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnc_limpiar
            // 
            this.btnc_limpiar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnc_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc_limpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnc_limpiar.Location = new System.Drawing.Point(341, 77);
            this.btnc_limpiar.Name = "btnc_limpiar";
            this.btnc_limpiar.Size = new System.Drawing.Size(92, 37);
            this.btnc_limpiar.TabIndex = 4;
            this.btnc_limpiar.Text = "Limpiar";
            this.btnc_limpiar.UseVisualStyleBackColor = false;
            this.btnc_limpiar.Click += new System.EventHandler(this.btnc_limpiar_Click);
            // 
            // litvc_usuario
            // 
            this.litvc_usuario.HideSelection = false;
            this.litvc_usuario.Location = new System.Drawing.Point(7, 120);
            this.litvc_usuario.Name = "litvc_usuario";
            this.litvc_usuario.Size = new System.Drawing.Size(546, 232);
            this.litvc_usuario.TabIndex = 3;
            this.litvc_usuario.UseCompatibleStateImageBehavior = false;
            // 
            // btnc_consultar
            // 
            this.btnc_consultar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnc_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc_consultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnc_consultar.Location = new System.Drawing.Point(152, 77);
            this.btnc_consultar.Name = "btnc_consultar";
            this.btnc_consultar.Size = new System.Drawing.Size(87, 37);
            this.btnc_consultar.TabIndex = 2;
            this.btnc_consultar.Text = "Consultar";
            this.btnc_consultar.UseVisualStyleBackColor = false;
            this.btnc_consultar.Click += new System.EventHandler(this.btnc_consultar_Click);
            // 
            // cbc_usuario
            // 
            this.cbc_usuario.FormattingEnabled = true;
            this.cbc_usuario.Location = new System.Drawing.Point(95, 29);
            this.cbc_usuario.Name = "cbc_usuario";
            this.cbc_usuario.Size = new System.Drawing.Size(253, 21);
            this.cbc_usuario.TabIndex = 1;
            this.cbc_usuario.Text = "-- Seleccione --";
            // 
            // labelc_usuario
            // 
            this.labelc_usuario.AutoSize = true;
            this.labelc_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelc_usuario.Location = new System.Drawing.Point(27, 33);
            this.labelc_usuario.Name = "labelc_usuario";
            this.labelc_usuario.Size = new System.Drawing.Size(50, 13);
            this.labelc_usuario.TabIndex = 0;
            this.labelc_usuario.Text = "Usuario";
            // 
            // tp_agregar
            // 
            this.tp_agregar.Controls.Add(this.groupBox2);
            this.tp_agregar.Location = new System.Drawing.Point(4, 22);
            this.tp_agregar.Name = "tp_agregar";
            this.tp_agregar.Padding = new System.Windows.Forms.Padding(3);
            this.tp_agregar.Size = new System.Drawing.Size(568, 369);
            this.tp_agregar.TabIndex = 1;
            this.tp_agregar.Text = "Agregar";
            this.tp_agregar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb_codempleadosa);
            this.groupBox2.Controls.Add(this.labela_usuario);
            this.groupBox2.Controls.Add(this.labela_apellido);
            this.groupBox2.Controls.Add(this.labela_nombre);
            this.groupBox2.Controls.Add(this.btna_consultar);
            this.groupBox2.Controls.Add(this.txtboxa_clave);
            this.groupBox2.Controls.Add(this.txtboxa_usuario);
            this.groupBox2.Controls.Add(this.txtboxa_apellido);
            this.groupBox2.Controls.Add(this.txtboxa_nombre);
            this.groupBox2.Controls.Add(this.btna_guardar);
            this.groupBox2.Controls.Add(this.labela_clave);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 357);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // labela_usuario
            // 
            this.labela_usuario.AutoSize = true;
            this.labela_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela_usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labela_usuario.Location = new System.Drawing.Point(15, 133);
            this.labela_usuario.Name = "labela_usuario";
            this.labela_usuario.Size = new System.Drawing.Size(50, 13);
            this.labela_usuario.TabIndex = 15;
            this.labela_usuario.Text = "Usuario";
            // 
            // labela_apellido
            // 
            this.labela_apellido.AutoSize = true;
            this.labela_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela_apellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labela_apellido.Location = new System.Drawing.Point(14, 89);
            this.labela_apellido.Name = "labela_apellido";
            this.labela_apellido.Size = new System.Drawing.Size(52, 13);
            this.labela_apellido.TabIndex = 14;
            this.labela_apellido.Text = "Apellido";
            // 
            // labela_nombre
            // 
            this.labela_nombre.AutoSize = true;
            this.labela_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela_nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labela_nombre.Location = new System.Drawing.Point(14, 42);
            this.labela_nombre.Name = "labela_nombre";
            this.labela_nombre.Size = new System.Drawing.Size(50, 13);
            this.labela_nombre.TabIndex = 13;
            this.labela_nombre.Text = "Nombre";
            // 
            // btna_consultar
            // 
            this.btna_consultar.BackColor = System.Drawing.Color.DarkGreen;
            this.btna_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btna_consultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btna_consultar.Location = new System.Drawing.Point(336, 274);
            this.btna_consultar.Name = "btna_consultar";
            this.btna_consultar.Size = new System.Drawing.Size(143, 33);
            this.btna_consultar.TabIndex = 11;
            this.btna_consultar.Text = "Limpiar";
            this.btna_consultar.UseVisualStyleBackColor = false;
            this.btna_consultar.Click += new System.EventHandler(this.btna_consultar_Click);
            // 
            // txtboxa_clave
            // 
            this.txtboxa_clave.Location = new System.Drawing.Point(135, 170);
            this.txtboxa_clave.MaxLength = 60;
            this.txtboxa_clave.Name = "txtboxa_clave";
            this.txtboxa_clave.Size = new System.Drawing.Size(404, 20);
            this.txtboxa_clave.TabIndex = 10;
            // 
            // txtboxa_usuario
            // 
            this.txtboxa_usuario.Location = new System.Drawing.Point(135, 126);
            this.txtboxa_usuario.MaxLength = 15;
            this.txtboxa_usuario.Name = "txtboxa_usuario";
            this.txtboxa_usuario.Size = new System.Drawing.Size(404, 20);
            this.txtboxa_usuario.TabIndex = 9;
            // 
            // txtboxa_apellido
            // 
            this.txtboxa_apellido.Location = new System.Drawing.Point(135, 82);
            this.txtboxa_apellido.MaxLength = 50;
            this.txtboxa_apellido.Name = "txtboxa_apellido";
            this.txtboxa_apellido.Size = new System.Drawing.Size(404, 20);
            this.txtboxa_apellido.TabIndex = 8;
            // 
            // txtboxa_nombre
            // 
            this.txtboxa_nombre.Location = new System.Drawing.Point(135, 39);
            this.txtboxa_nombre.MaxLength = 60;
            this.txtboxa_nombre.Name = "txtboxa_nombre";
            this.txtboxa_nombre.Size = new System.Drawing.Size(404, 20);
            this.txtboxa_nombre.TabIndex = 7;
            // 
            // btna_guardar
            // 
            this.btna_guardar.BackColor = System.Drawing.Color.DarkGreen;
            this.btna_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btna_guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btna_guardar.Location = new System.Drawing.Point(76, 274);
            this.btna_guardar.Name = "btna_guardar";
            this.btna_guardar.Size = new System.Drawing.Size(142, 33);
            this.btna_guardar.TabIndex = 5;
            this.btna_guardar.Text = "Guardar";
            this.btna_guardar.UseVisualStyleBackColor = false;
            this.btna_guardar.Click += new System.EventHandler(this.btna_guardar_Click);
            // 
            // labela_clave
            // 
            this.labela_clave.AutoSize = true;
            this.labela_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela_clave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labela_clave.Location = new System.Drawing.Point(15, 177);
            this.labela_clave.Name = "labela_clave";
            this.labela_clave.Size = new System.Drawing.Size(71, 13);
            this.labela_clave.TabIndex = 4;
            this.labela_clave.Text = "Contraseña";
            // 
            // tp_editar
            // 
            this.tp_editar.Controls.Add(this.groupBox3);
            this.tp_editar.Location = new System.Drawing.Point(4, 22);
            this.tp_editar.Name = "tp_editar";
            this.tp_editar.Size = new System.Drawing.Size(568, 369);
            this.tp_editar.TabIndex = 2;
            this.tp_editar.Text = "Editar";
            this.tp_editar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cb_codempleadoed);
            this.groupBox3.Controls.Add(this.labeled_estado);
            this.groupBox3.Controls.Add(this.cbed_estado);
            this.groupBox3.Controls.Add(this.txtboxed_clave);
            this.groupBox3.Controls.Add(this.txtboxed_usuario);
            this.groupBox3.Controls.Add(this.txtboxed_apellido);
            this.groupBox3.Controls.Add(this.txtboxed_nombre);
            this.groupBox3.Controls.Add(this.btn_actualizar);
            this.groupBox3.Controls.Add(this.labeled_clave);
            this.groupBox3.Controls.Add(this.labeled_usuario2);
            this.groupBox3.Controls.Add(this.labeled_apellido);
            this.groupBox3.Controls.Add(this.labeled_nombre);
            this.groupBox3.Controls.Add(this.btned_consultar);
            this.groupBox3.Controls.Add(this.cbed_usuario);
            this.groupBox3.Controls.Add(this.labeled_usuario);
            this.groupBox3.Location = new System.Drawing.Point(5, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 363);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // labeled_estado
            // 
            this.labeled_estado.AutoSize = true;
            this.labeled_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_estado.Location = new System.Drawing.Point(14, 284);
            this.labeled_estado.Name = "labeled_estado";
            this.labeled_estado.Size = new System.Drawing.Size(46, 13);
            this.labeled_estado.TabIndex = 14;
            this.labeled_estado.Text = "Estado";
            // 
            // cbed_estado
            // 
            this.cbed_estado.FormattingEnabled = true;
            this.cbed_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbed_estado.Location = new System.Drawing.Point(90, 280);
            this.cbed_estado.Name = "cbed_estado";
            this.cbed_estado.Size = new System.Drawing.Size(121, 21);
            this.cbed_estado.TabIndex = 13;
            // 
            // txtboxed_clave
            // 
            this.txtboxed_clave.Location = new System.Drawing.Point(90, 237);
            this.txtboxed_clave.Name = "txtboxed_clave";
            this.txtboxed_clave.Size = new System.Drawing.Size(444, 20);
            this.txtboxed_clave.TabIndex = 12;
            // 
            // txtboxed_usuario
            // 
            this.txtboxed_usuario.Location = new System.Drawing.Point(90, 196);
            this.txtboxed_usuario.Name = "txtboxed_usuario";
            this.txtboxed_usuario.Size = new System.Drawing.Size(444, 20);
            this.txtboxed_usuario.TabIndex = 11;
            // 
            // txtboxed_apellido
            // 
            this.txtboxed_apellido.Location = new System.Drawing.Point(90, 151);
            this.txtboxed_apellido.Name = "txtboxed_apellido";
            this.txtboxed_apellido.Size = new System.Drawing.Size(444, 20);
            this.txtboxed_apellido.TabIndex = 10;
            // 
            // txtboxed_nombre
            // 
            this.txtboxed_nombre.Location = new System.Drawing.Point(90, 102);
            this.txtboxed_nombre.Name = "txtboxed_nombre";
            this.txtboxed_nombre.Size = new System.Drawing.Size(444, 20);
            this.txtboxed_nombre.TabIndex = 9;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_actualizar.Location = new System.Drawing.Point(240, 317);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(127, 29);
            this.btn_actualizar.TabIndex = 8;
            this.btn_actualizar.Text = "Guardar Cambios";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // labeled_clave
            // 
            this.labeled_clave.AutoSize = true;
            this.labeled_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_clave.Location = new System.Drawing.Point(11, 237);
            this.labeled_clave.Name = "labeled_clave";
            this.labeled_clave.Size = new System.Drawing.Size(71, 13);
            this.labeled_clave.TabIndex = 6;
            this.labeled_clave.Text = "Contraseña";
            // 
            // labeled_usuario2
            // 
            this.labeled_usuario2.AutoSize = true;
            this.labeled_usuario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_usuario2.Location = new System.Drawing.Point(11, 196);
            this.labeled_usuario2.Name = "labeled_usuario2";
            this.labeled_usuario2.Size = new System.Drawing.Size(50, 13);
            this.labeled_usuario2.TabIndex = 5;
            this.labeled_usuario2.Text = "Usuario";
            // 
            // labeled_apellido
            // 
            this.labeled_apellido.AutoSize = true;
            this.labeled_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_apellido.Location = new System.Drawing.Point(11, 151);
            this.labeled_apellido.Name = "labeled_apellido";
            this.labeled_apellido.Size = new System.Drawing.Size(52, 13);
            this.labeled_apellido.TabIndex = 4;
            this.labeled_apellido.Text = "Apellido";
            // 
            // labeled_nombre
            // 
            this.labeled_nombre.AutoSize = true;
            this.labeled_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_nombre.Location = new System.Drawing.Point(11, 102);
            this.labeled_nombre.Name = "labeled_nombre";
            this.labeled_nombre.Size = new System.Drawing.Size(50, 13);
            this.labeled_nombre.TabIndex = 3;
            this.labeled_nombre.Text = "Nombre";
            // 
            // btned_consultar
            // 
            this.btned_consultar.BackColor = System.Drawing.Color.DarkGreen;
            this.btned_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btned_consultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btned_consultar.Location = new System.Drawing.Point(238, 58);
            this.btned_consultar.Name = "btned_consultar";
            this.btned_consultar.Size = new System.Drawing.Size(129, 28);
            this.btned_consultar.TabIndex = 2;
            this.btned_consultar.Text = "Consultar";
            this.btned_consultar.UseVisualStyleBackColor = false;
            this.btned_consultar.Click += new System.EventHandler(this.btned_consultar_Click);
            // 
            // cbed_usuario
            // 
            this.cbed_usuario.FormattingEnabled = true;
            this.cbed_usuario.Location = new System.Drawing.Point(90, 22);
            this.cbed_usuario.Name = "cbed_usuario";
            this.cbed_usuario.Size = new System.Drawing.Size(444, 21);
            this.cbed_usuario.TabIndex = 1;
            this.cbed_usuario.Text = "-- Seleccione --";
            // 
            // labeled_usuario
            // 
            this.labeled_usuario.AutoSize = true;
            this.labeled_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_usuario.Location = new System.Drawing.Point(8, 27);
            this.labeled_usuario.Name = "labeled_usuario";
            this.labeled_usuario.Size = new System.Drawing.Size(50, 13);
            this.labeled_usuario.TabIndex = 0;
            this.labeled_usuario.Text = "Usuario";
            // 
            // tp_eliminar
            // 
            this.tp_eliminar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tp_eliminar.Controls.Add(this.groupBox4);
            this.tp_eliminar.Location = new System.Drawing.Point(4, 22);
            this.tp_eliminar.Name = "tp_eliminar";
            this.tp_eliminar.Size = new System.Drawing.Size(568, 369);
            this.tp_eliminar.TabIndex = 3;
            this.tp_eliminar.Text = "Eliminar";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.btne_eliminar);
            this.groupBox4.Controls.Add(this.cbe_usuario);
            this.groupBox4.Controls.Add(this.labele_usuario);
            this.groupBox4.Location = new System.Drawing.Point(61, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 190);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // btne_eliminar
            // 
            this.btne_eliminar.BackColor = System.Drawing.Color.DarkGreen;
            this.btne_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btne_eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btne_eliminar.Location = new System.Drawing.Point(174, 115);
            this.btne_eliminar.Name = "btne_eliminar";
            this.btne_eliminar.Size = new System.Drawing.Size(101, 36);
            this.btne_eliminar.TabIndex = 5;
            this.btne_eliminar.Text = "Eliminar";
            this.btne_eliminar.UseVisualStyleBackColor = false;
            this.btne_eliminar.Click += new System.EventHandler(this.btne_eliminar_Click);
            // 
            // cbe_usuario
            // 
            this.cbe_usuario.FormattingEnabled = true;
            this.cbe_usuario.Location = new System.Drawing.Point(118, 53);
            this.cbe_usuario.Name = "cbe_usuario";
            this.cbe_usuario.Size = new System.Drawing.Size(285, 21);
            this.cbe_usuario.TabIndex = 4;
            this.cbe_usuario.Text = " -- Seleccione --";
            // 
            // labele_usuario
            // 
            this.labele_usuario.AutoSize = true;
            this.labele_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labele_usuario.Location = new System.Drawing.Point(47, 56);
            this.labele_usuario.Name = "labele_usuario";
            this.labele_usuario.Size = new System.Drawing.Size(50, 13);
            this.labele_usuario.TabIndex = 3;
            this.labele_usuario.Text = "Usuario";
            // 
            // cb_codempleadosa
            // 
            this.cb_codempleadosa.FormattingEnabled = true;
            this.cb_codempleadosa.Location = new System.Drawing.Point(135, 212);
            this.cb_codempleadosa.Name = "cb_codempleadosa";
            this.cb_codempleadosa.Size = new System.Drawing.Size(278, 21);
            this.cb_codempleadosa.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Código Empleado";
            // 
            // cb_codempleadoed
            // 
            this.cb_codempleadoed.FormattingEnabled = true;
            this.cb_codempleadoed.Location = new System.Drawing.Point(337, 280);
            this.cb_codempleadoed.Name = "cb_codempleadoed";
            this.cb_codempleadoed.Size = new System.Drawing.Size(197, 21);
            this.cb_codempleadoed.TabIndex = 18;
            // 
            // FormUsuarios
            // 
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(614, 471);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tc_usuarios);
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Usuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.tc_usuarios.ResumeLayout(false);
            this.tp_consultar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tp_agregar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tp_editar.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tp_eliminar.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /// <summary>
        /// Boton Consultar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnc_consultar_Click(object sender, EventArgs e)
        {
            addListView();
        }
        /// <summary>
        /// Boton Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnc_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        /// <summary>
        /// Boton Guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btna_guardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        /// <summary>
        /// Boton Consultar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btna_consultar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        /// <summary>
        /// Boton Consular y Buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btned_consultar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        /// <summary>
        /// Boton Actualizar, Editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            editar();
        }
        /// <summary>
        /// Boton Eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btne_eliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            //Propiedades del ListView
            litvc_usuario.View = View.Details;
            litvc_usuario.GridLines = true;
            litvc_usuario.FullRowSelect = true;

            //Columnas
            litvc_usuario.Columns.Add("Id", 30, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("Nombre", 70, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("Apellido", 150, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("Usuario", 50, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("estado", 50, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("fecha_creacion", 50, HorizontalAlignment.Left);
            litvc_usuario.Columns.Add("Código Empleado", 50, HorizontalAlignment.Left);
            ///
            ///Conecccion con las Base de Datos columna Usuario de la tabal usuarios
            ///
            conMysql.Connect();
            String sql = "select id, usuario from usuarios";
            conMysql.CargarCombo(cbc_usuario, sql, "usuario", "id");
            conMysql.CargarCombo(cbed_usuario, sql, "usuario", "id");
            conMysql.CargarCombo(cbe_usuario, sql, "usuario", "id");
            ///
            ///Conecccion con las Base de Datos columna Codempleado, nombre apellidos en la tabla empleados
            ///
            String sql2 = "select codempleado, concat(codempleado, ' - ', nombre,' ', apellido) nombre from empleados";
            conMysql.CargarCombo(cb_codempleadosa, sql2, "nombre", "codempleado");
            conMysql.CargarCombo(cb_codempleadoed, sql2, "nombre", "codempleado");
        }
    }
}
