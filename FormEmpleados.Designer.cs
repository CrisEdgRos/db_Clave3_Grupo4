
namespace Clave3_Grupo4
{
    partial class FormEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cbag_cargoEmp = new System.Windows.Forms.ComboBox();
            this.txtag_cuentabanEmp = new System.Windows.Forms.TextBox();
            this.labelag_cuentaEmp = new System.Windows.Forms.Label();
            this.labelag_telefonoEmp = new System.Windows.Forms.Label();
            this.labelag_salarioEmp = new System.Windows.Forms.Label();
            this.txtag_telefonoEmp = new System.Windows.Forms.TextBox();
            this.txtag_salarioEmp = new System.Windows.Forms.TextBox();
            this.labelag_correo = new System.Windows.Forms.Label();
            this.labelag_cargoEmp = new System.Windows.Forms.Label();
            this.labelag_duiEmp = new System.Windows.Forms.Label();
            this.txtag_duiEmp = new System.Windows.Forms.TextBox();
            this.labela_direccionEmp = new System.Windows.Forms.Label();
            this.labela_apellidoEmp = new System.Windows.Forms.Label();
            this.labela_nombreEmp = new System.Windows.Forms.Label();
            this.btna_consultarEmp = new System.Windows.Forms.Button();
            this.txtboxa_direccionEmp = new System.Windows.Forms.TextBox();
            this.txtboxa_apellidoEmp = new System.Windows.Forms.TextBox();
            this.txtboxa_nombreEmp = new System.Windows.Forms.TextBox();
            this.btna_guardarEmp = new System.Windows.Forms.Button();
            this.labela_fechaingresoEmp = new System.Windows.Forms.Label();
            this.tp_editarEmp = new System.Windows.Forms.TabPage();
            this.groupBox3Emp = new System.Windows.Forms.GroupBox();
            this.txtCorreoed_emp = new System.Windows.Forms.TextBox();
            this.txted_duiEmp = new System.Windows.Forms.TextBox();
            this.txed_codigoEmp = new System.Windows.Forms.TextBox();
            this.labeled_duiEmp = new System.Windows.Forms.Label();
            this.labeled_codigo2Emp = new System.Windows.Forms.Label();
            this.labeled_ceuntabancariaEmp = new System.Windows.Forms.Label();
            this.txted_cuentabancariaEmp = new System.Windows.Forms.TextBox();
            this.txted_telefonoEmp = new System.Windows.Forms.TextBox();
            this.labeled_telefonoEmp = new System.Windows.Forms.Label();
            this.labeled_salarioEmp = new System.Windows.Forms.Label();
            this.labeled_departamentoEmp = new System.Windows.Forms.Label();
            this.cbed_cargoEmp = new System.Windows.Forms.ComboBox();
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
            this.label14.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label14.Location = new System.Drawing.Point(23, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(572, 34);
            this.label14.TabIndex = 3;
            this.label14.Text = "MANTENIMIENTO DE EMPLEADOS";
            // 
            // tc_usuariosEmp
            // 
            this.tc_usuariosEmp.Controls.Add(this.tp_consultarEmp);
            this.tc_usuariosEmp.Controls.Add(this.tp_agregarEmp);
            this.tc_usuariosEmp.Controls.Add(this.tp_editarEmp);
            this.tc_usuariosEmp.Controls.Add(this.tp_eliminarEmp);
            this.tc_usuariosEmp.Location = new System.Drawing.Point(19, 51);
            this.tc_usuariosEmp.Name = "tc_usuariosEmp";
            this.tc_usuariosEmp.SelectedIndex = 0;
            this.tc_usuariosEmp.Size = new System.Drawing.Size(576, 395);
            this.tc_usuariosEmp.TabIndex = 2;
            // 
            // tp_consultarEmp
            // 
            this.tp_consultarEmp.Controls.Add(this.groupBox1Emp);
            this.tp_consultarEmp.Location = new System.Drawing.Point(4, 22);
            this.tp_consultarEmp.Name = "tp_consultarEmp";
            this.tp_consultarEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tp_consultarEmp.Size = new System.Drawing.Size(568, 369);
            this.tp_consultarEmp.TabIndex = 0;
            this.tp_consultarEmp.Text = "Consultar";
            this.tp_consultarEmp.UseVisualStyleBackColor = true;
            // 
            // groupBox1Emp
            // 
            this.groupBox1Emp.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1Emp.Controls.Add(this.btnc_limpiarEmp);
            this.groupBox1Emp.Controls.Add(this.litvc_usuarioEmp);
            this.groupBox1Emp.Controls.Add(this.btnc_consultarEmp);
            this.groupBox1Emp.Controls.Add(this.cbc_codigoEmp);
            this.groupBox1Emp.Controls.Add(this.labelc_codigoEmp);
            this.groupBox1Emp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1Emp.Location = new System.Drawing.Point(3, 7);
            this.groupBox1Emp.Name = "groupBox1Emp";
            this.groupBox1Emp.Size = new System.Drawing.Size(559, 359);
            this.groupBox1Emp.TabIndex = 0;
            this.groupBox1Emp.TabStop = false;
            this.groupBox1Emp.Enter += new System.EventHandler(this.groupBox1Emp_Enter);
            // 
            // btnc_limpiarEmp
            // 
            this.btnc_limpiarEmp.BackColor = System.Drawing.Color.DarkGreen;
            this.btnc_limpiarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc_limpiarEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnc_limpiarEmp.Location = new System.Drawing.Point(331, 77);
            this.btnc_limpiarEmp.Name = "btnc_limpiarEmp";
            this.btnc_limpiarEmp.Size = new System.Drawing.Size(102, 37);
            this.btnc_limpiarEmp.TabIndex = 4;
            this.btnc_limpiarEmp.Text = "Limpiar";
            this.btnc_limpiarEmp.UseVisualStyleBackColor = false;
            this.btnc_limpiarEmp.Click += new System.EventHandler(this.btnc_limpiar_Click);
            // 
            // litvc_usuarioEmp
            // 
            this.litvc_usuarioEmp.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.litvc_usuarioEmp.HideSelection = false;
            this.litvc_usuarioEmp.Location = new System.Drawing.Point(7, 120);
            this.litvc_usuarioEmp.Name = "litvc_usuarioEmp";
            this.litvc_usuarioEmp.Size = new System.Drawing.Size(546, 232);
            this.litvc_usuarioEmp.TabIndex = 3;
            this.litvc_usuarioEmp.UseCompatibleStateImageBehavior = false;
            // 
            // btnc_consultarEmp
            // 
            this.btnc_consultarEmp.BackColor = System.Drawing.Color.DarkGreen;
            this.btnc_consultarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc_consultarEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnc_consultarEmp.Location = new System.Drawing.Point(152, 77);
            this.btnc_consultarEmp.Name = "btnc_consultarEmp";
            this.btnc_consultarEmp.Size = new System.Drawing.Size(105, 37);
            this.btnc_consultarEmp.TabIndex = 2;
            this.btnc_consultarEmp.Text = "Consultar";
            this.btnc_consultarEmp.UseVisualStyleBackColor = false;
            this.btnc_consultarEmp.Click += new System.EventHandler(this.btnc_consultar_Click);
            // 
            // cbc_codigoEmp
            // 
            this.cbc_codigoEmp.FormattingEnabled = true;
            this.cbc_codigoEmp.Location = new System.Drawing.Point(95, 29);
            this.cbc_codigoEmp.Name = "cbc_codigoEmp";
            this.cbc_codigoEmp.Size = new System.Drawing.Size(253, 21);
            this.cbc_codigoEmp.TabIndex = 1;
            this.cbc_codigoEmp.Text = "-- Seleccione --";
            // 
            // labelc_codigoEmp
            // 
            this.labelc_codigoEmp.AutoSize = true;
            this.labelc_codigoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelc_codigoEmp.Location = new System.Drawing.Point(24, 32);
            this.labelc_codigoEmp.Name = "labelc_codigoEmp";
            this.labelc_codigoEmp.Size = new System.Drawing.Size(52, 15);
            this.labelc_codigoEmp.TabIndex = 0;
            this.labelc_codigoEmp.Text = "Codigo";
            // 
            // tp_agregarEmp
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
            // groupBox2Emp
            // 
            this.groupBox2Emp.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2Emp.Controls.Add(this.dateTimePicker1);
            this.groupBox2Emp.Controls.Add(this.txtCorreo);
            this.groupBox2Emp.Controls.Add(this.cbag_cargoEmp);
            this.groupBox2Emp.Controls.Add(this.txtag_cuentabanEmp);
            this.groupBox2Emp.Controls.Add(this.labelag_cuentaEmp);
            this.groupBox2Emp.Controls.Add(this.labelag_telefonoEmp);
            this.groupBox2Emp.Controls.Add(this.labelag_salarioEmp);
            this.groupBox2Emp.Controls.Add(this.txtag_telefonoEmp);
            this.groupBox2Emp.Controls.Add(this.txtag_salarioEmp);
            this.groupBox2Emp.Controls.Add(this.labelag_correo);
            this.groupBox2Emp.Controls.Add(this.labelag_cargoEmp);
            this.groupBox2Emp.Controls.Add(this.labelag_duiEmp);
            this.groupBox2Emp.Controls.Add(this.txtag_duiEmp);
            this.groupBox2Emp.Controls.Add(this.labela_direccionEmp);
            this.groupBox2Emp.Controls.Add(this.labela_apellidoEmp);
            this.groupBox2Emp.Controls.Add(this.labela_nombreEmp);
            this.groupBox2Emp.Controls.Add(this.btna_consultarEmp);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(90, 156);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(443, 20);
            this.txtCorreo.TabIndex = 30;
            // 
            // cbag_cargoEmp
            // 
            this.cbag_cargoEmp.FormattingEnabled = true;
            this.cbag_cargoEmp.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbag_cargoEmp.Location = new System.Drawing.Point(90, 192);
            this.cbag_cargoEmp.Name = "cbag_cargoEmp";
            this.cbag_cargoEmp.Size = new System.Drawing.Size(443, 21);
            this.cbag_cargoEmp.TabIndex = 29;
            // 
            // txtag_cuentabanEmp
            // 
            this.txtag_cuentabanEmp.Location = new System.Drawing.Point(239, 274);
            this.txtag_cuentabanEmp.Name = "txtag_cuentabanEmp";
            this.txtag_cuentabanEmp.Size = new System.Drawing.Size(155, 20);
            this.txtag_cuentabanEmp.TabIndex = 28;
            // 
            // labelag_cuentaEmp
            // 
            this.labelag_cuentaEmp.AutoSize = true;
            this.labelag_cuentaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelag_cuentaEmp.Location = new System.Drawing.Point(124, 277);
            this.labelag_cuentaEmp.Name = "labelag_cuentaEmp";
            this.labelag_cuentaEmp.Size = new System.Drawing.Size(101, 13);
            this.labelag_cuentaEmp.TabIndex = 27;
            this.labelag_cuentaEmp.Text = "Cuenta Bancaria";
            // 
            // labelag_telefonoEmp
            // 
            this.labelag_telefonoEmp.AutoSize = true;
            this.labelag_telefonoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelag_telefonoEmp.Location = new System.Drawing.Point(289, 235);
            this.labelag_telefonoEmp.Name = "labelag_telefonoEmp";
            this.labelag_telefonoEmp.Size = new System.Drawing.Size(57, 13);
            this.labelag_telefonoEmp.TabIndex = 26;
            this.labelag_telefonoEmp.Text = "Telefono";
            // 
            // labelag_salarioEmp
            // 
            this.labelag_salarioEmp.AutoSize = true;
            this.labelag_salarioEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelag_salarioEmp.Location = new System.Drawing.Point(9, 236);
            this.labelag_salarioEmp.Name = "labelag_salarioEmp";
            this.labelag_salarioEmp.Size = new System.Drawing.Size(46, 13);
            this.labelag_salarioEmp.TabIndex = 25;
            this.labelag_salarioEmp.Text = "Salario";
            // 
            // txtag_telefonoEmp
            // 
            this.txtag_telefonoEmp.Location = new System.Drawing.Point(361, 231);
            this.txtag_telefonoEmp.Name = "txtag_telefonoEmp";
            this.txtag_telefonoEmp.Size = new System.Drawing.Size(172, 20);
            this.txtag_telefonoEmp.TabIndex = 24;
            // 
            // txtag_salarioEmp
            // 
            this.txtag_salarioEmp.Location = new System.Drawing.Point(89, 231);
            this.txtag_salarioEmp.Name = "txtag_salarioEmp";
            this.txtag_salarioEmp.Size = new System.Drawing.Size(144, 20);
            this.txtag_salarioEmp.TabIndex = 23;
            // 
            // labelag_correo
            // 
            this.labelag_correo.AutoSize = true;
            this.labelag_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelag_correo.Location = new System.Drawing.Point(9, 156);
            this.labelag_correo.Name = "labelag_correo";
            this.labelag_correo.Size = new System.Drawing.Size(44, 13);
            this.labelag_correo.TabIndex = 21;
            this.labelag_correo.Text = "Correo";
            // 
            // labelag_cargoEmp
            // 
            this.labelag_cargoEmp.AutoSize = true;
            this.labelag_cargoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelag_cargoEmp.Location = new System.Drawing.Point(10, 200);
            this.labelag_cargoEmp.Name = "labelag_cargoEmp";
            this.labelag_cargoEmp.Size = new System.Drawing.Size(40, 13);
            this.labelag_cargoEmp.TabIndex = 20;
            this.labelag_cargoEmp.Text = "Cargo";
            // 
            // labelag_duiEmp
            // 
            this.labelag_duiEmp.AutoSize = true;
            this.labelag_duiEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelag_duiEmp.Location = new System.Drawing.Point(285, 25);
            this.labelag_duiEmp.Name = "labelag_duiEmp";
            this.labelag_duiEmp.Size = new System.Drawing.Size(29, 13);
            this.labelag_duiEmp.TabIndex = 19;
            this.labelag_duiEmp.Text = "DUI";
            // 
            // txtag_duiEmp
            // 
            this.txtag_duiEmp.Location = new System.Drawing.Point(332, 22);
            this.txtag_duiEmp.Name = "txtag_duiEmp";
            this.txtag_duiEmp.Size = new System.Drawing.Size(204, 20);
            this.txtag_duiEmp.TabIndex = 18;
            // 
            // labela_direccionEmp
            // 
            this.labela_direccionEmp.AutoSize = true;
            this.labela_direccionEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela_direccionEmp.Location = new System.Drawing.Point(7, 122);
            this.labela_direccionEmp.Name = "labela_direccionEmp";
            this.labela_direccionEmp.Size = new System.Drawing.Size(61, 13);
            this.labela_direccionEmp.TabIndex = 15;
            this.labela_direccionEmp.Text = "Direccion";
            // 
            // labela_apellidoEmp
            // 
            this.labela_apellidoEmp.AutoSize = true;
            this.labela_apellidoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela_apellidoEmp.Location = new System.Drawing.Point(6, 89);
            this.labela_apellidoEmp.Name = "labela_apellidoEmp";
            this.labela_apellidoEmp.Size = new System.Drawing.Size(52, 13);
            this.labela_apellidoEmp.TabIndex = 14;
            this.labela_apellidoEmp.Text = "Apellido";
            // 
            // labela_nombreEmp
            // 
            this.labela_nombreEmp.AutoSize = true;
            this.labela_nombreEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela_nombreEmp.Location = new System.Drawing.Point(6, 56);
            this.labela_nombreEmp.Name = "labela_nombreEmp";
            this.labela_nombreEmp.Size = new System.Drawing.Size(50, 13);
            this.labela_nombreEmp.TabIndex = 13;
            this.labela_nombreEmp.Text = "Nombre";
            // 
            // btna_consultarEmp
            // 
            this.btna_consultarEmp.BackColor = System.Drawing.Color.DarkGreen;
            this.btna_consultarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btna_consultarEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btna_consultarEmp.Location = new System.Drawing.Point(332, 319);
            this.btna_consultarEmp.Name = "btna_consultarEmp";
            this.btna_consultarEmp.Size = new System.Drawing.Size(147, 32);
            this.btna_consultarEmp.TabIndex = 11;
            this.btna_consultarEmp.Text = "Limpiar";
            this.btna_consultarEmp.UseVisualStyleBackColor = false;
            this.btna_consultarEmp.Click += new System.EventHandler(this.btna_consultar_Click);
            // 
            // txtboxa_direccionEmp
            // 
            this.txtboxa_direccionEmp.Location = new System.Drawing.Point(89, 119);
            this.txtboxa_direccionEmp.MaxLength = 150;
            this.txtboxa_direccionEmp.Name = "txtboxa_direccionEmp";
            this.txtboxa_direccionEmp.Size = new System.Drawing.Size(447, 20);
            this.txtboxa_direccionEmp.TabIndex = 9;
            // 
            // txtboxa_apellidoEmp
            // 
            this.txtboxa_apellidoEmp.Location = new System.Drawing.Point(89, 85);
            this.txtboxa_apellidoEmp.MaxLength = 50;
            this.txtboxa_apellidoEmp.Name = "txtboxa_apellidoEmp";
            this.txtboxa_apellidoEmp.Size = new System.Drawing.Size(447, 20);
            this.txtboxa_apellidoEmp.TabIndex = 8;
            // 
            // txtboxa_nombreEmp
            // 
            this.txtboxa_nombreEmp.Location = new System.Drawing.Point(89, 54);
            this.txtboxa_nombreEmp.MaxLength = 60;
            this.txtboxa_nombreEmp.Name = "txtboxa_nombreEmp";
            this.txtboxa_nombreEmp.Size = new System.Drawing.Size(447, 20);
            this.txtboxa_nombreEmp.TabIndex = 7;
            // 
            // btna_guardarEmp
            // 
            this.btna_guardarEmp.BackColor = System.Drawing.Color.DarkGreen;
            this.btna_guardarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btna_guardarEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btna_guardarEmp.Location = new System.Drawing.Point(71, 319);
            this.btna_guardarEmp.Name = "btna_guardarEmp";
            this.btna_guardarEmp.Size = new System.Drawing.Size(141, 32);
            this.btna_guardarEmp.TabIndex = 5;
            this.btna_guardarEmp.Text = "Guardar";
            this.btna_guardarEmp.UseVisualStyleBackColor = false;
            this.btna_guardarEmp.Click += new System.EventHandler(this.btna_guardar_Click);
            // 
            // labela_fechaingresoEmp
            // 
            this.labela_fechaingresoEmp.AutoSize = true;
            this.labela_fechaingresoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela_fechaingresoEmp.Location = new System.Drawing.Point(1, 23);
            this.labela_fechaingresoEmp.Name = "labela_fechaingresoEmp";
            this.labela_fechaingresoEmp.Size = new System.Drawing.Size(88, 13);
            this.labela_fechaingresoEmp.TabIndex = 4;
            this.labela_fechaingresoEmp.Text = "Fecha Ingreso";
            // 
            // tp_editarEmp
            // 
            this.tp_editarEmp.Controls.Add(this.groupBox3Emp);
            this.tp_editarEmp.Location = new System.Drawing.Point(4, 22);
            this.tp_editarEmp.Name = "tp_editarEmp";
            this.tp_editarEmp.Size = new System.Drawing.Size(568, 369);
            this.tp_editarEmp.TabIndex = 2;
            this.tp_editarEmp.Text = "Editar";
            this.tp_editarEmp.UseVisualStyleBackColor = true;
            // 
            // groupBox3Emp
            // 
            this.groupBox3Emp.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3Emp.Controls.Add(this.txtCorreoed_emp);
            this.groupBox3Emp.Controls.Add(this.txted_duiEmp);
            this.groupBox3Emp.Controls.Add(this.txed_codigoEmp);
            this.groupBox3Emp.Controls.Add(this.labeled_duiEmp);
            this.groupBox3Emp.Controls.Add(this.labeled_codigo2Emp);
            this.groupBox3Emp.Controls.Add(this.labeled_ceuntabancariaEmp);
            this.groupBox3Emp.Controls.Add(this.txted_cuentabancariaEmp);
            this.groupBox3Emp.Controls.Add(this.txted_telefonoEmp);
            this.groupBox3Emp.Controls.Add(this.labeled_telefonoEmp);
            this.groupBox3Emp.Controls.Add(this.labeled_salarioEmp);
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
            this.groupBox3Emp.Location = new System.Drawing.Point(5, -2);
            this.groupBox3Emp.Name = "groupBox3Emp";
            this.groupBox3Emp.Size = new System.Drawing.Size(560, 363);
            this.groupBox3Emp.TabIndex = 0;
            this.groupBox3Emp.TabStop = false;
            // 
            // txtCorreoed_emp
            // 
            this.txtCorreoed_emp.Location = new System.Drawing.Point(90, 257);
            this.txtCorreoed_emp.Name = "txtCorreoed_emp";
            this.txtCorreoed_emp.Size = new System.Drawing.Size(188, 20);
            this.txtCorreoed_emp.TabIndex = 26;
            // 
            // txted_duiEmp
            // 
            this.txted_duiEmp.Location = new System.Drawing.Point(377, 186);
            this.txted_duiEmp.Name = "txted_duiEmp";
            this.txted_duiEmp.Size = new System.Drawing.Size(157, 20);
            this.txted_duiEmp.TabIndex = 25;
            // 
            // txed_codigoEmp
            // 
            this.txed_codigoEmp.Location = new System.Drawing.Point(93, 188);
            this.txed_codigoEmp.Name = "txed_codigoEmp";
            this.txed_codigoEmp.ReadOnly = true;
            this.txed_codigoEmp.Size = new System.Drawing.Size(185, 20);
            this.txed_codigoEmp.TabIndex = 24;
            // 
            // labeled_duiEmp
            // 
            this.labeled_duiEmp.AutoSize = true;
            this.labeled_duiEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_duiEmp.Location = new System.Drawing.Point(319, 191);
            this.labeled_duiEmp.Name = "labeled_duiEmp";
            this.labeled_duiEmp.Size = new System.Drawing.Size(29, 13);
            this.labeled_duiEmp.TabIndex = 23;
            this.labeled_duiEmp.Text = "DUI";
            // 
            // labeled_codigo2Emp
            // 
            this.labeled_codigo2Emp.AutoSize = true;
            this.labeled_codigo2Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_codigo2Emp.Location = new System.Drawing.Point(16, 192);
            this.labeled_codigo2Emp.Name = "labeled_codigo2Emp";
            this.labeled_codigo2Emp.Size = new System.Drawing.Size(46, 13);
            this.labeled_codigo2Emp.TabIndex = 22;
            this.labeled_codigo2Emp.Text = "Cadigo";
            // 
            // labeled_ceuntabancariaEmp
            // 
            this.labeled_ceuntabancariaEmp.AutoSize = true;
            this.labeled_ceuntabancariaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_ceuntabancariaEmp.Location = new System.Drawing.Point(266, 294);
            this.labeled_ceuntabancariaEmp.Name = "labeled_ceuntabancariaEmp";
            this.labeled_ceuntabancariaEmp.Size = new System.Drawing.Size(101, 13);
            this.labeled_ceuntabancariaEmp.TabIndex = 21;
            this.labeled_ceuntabancariaEmp.Text = "Cuenta Bancaria";
            // 
            // txted_cuentabancariaEmp
            // 
            this.txted_cuentabancariaEmp.Location = new System.Drawing.Point(377, 291);
            this.txted_cuentabancariaEmp.Name = "txted_cuentabancariaEmp";
            this.txted_cuentabancariaEmp.Size = new System.Drawing.Size(157, 20);
            this.txted_cuentabancariaEmp.TabIndex = 20;
            // 
            // txted_telefonoEmp
            // 
            this.txted_telefonoEmp.Location = new System.Drawing.Point(377, 254);
            this.txted_telefonoEmp.Name = "txted_telefonoEmp";
            this.txted_telefonoEmp.Size = new System.Drawing.Size(157, 20);
            this.txted_telefonoEmp.TabIndex = 19;
            // 
            // labeled_telefonoEmp
            // 
            this.labeled_telefonoEmp.AutoSize = true;
            this.labeled_telefonoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_telefonoEmp.Location = new System.Drawing.Point(296, 261);
            this.labeled_telefonoEmp.Name = "labeled_telefonoEmp";
            this.labeled_telefonoEmp.Size = new System.Drawing.Size(57, 13);
            this.labeled_telefonoEmp.TabIndex = 18;
            this.labeled_telefonoEmp.Text = "Telefono";
            // 
            // labeled_salarioEmp
            // 
            this.labeled_salarioEmp.AutoSize = true;
            this.labeled_salarioEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_salarioEmp.Location = new System.Drawing.Point(16, 298);
            this.labeled_salarioEmp.Name = "labeled_salarioEmp";
            this.labeled_salarioEmp.Size = new System.Drawing.Size(46, 13);
            this.labeled_salarioEmp.TabIndex = 17;
            this.labeled_salarioEmp.Text = "Salario";
            // 
            // labeled_departamentoEmp
            // 
            this.labeled_departamentoEmp.AutoSize = true;
            this.labeled_departamentoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_departamentoEmp.Location = new System.Drawing.Point(16, 264);
            this.labeled_departamentoEmp.Name = "labeled_departamentoEmp";
            this.labeled_departamentoEmp.Size = new System.Drawing.Size(44, 13);
            this.labeled_departamentoEmp.TabIndex = 14;
            this.labeled_departamentoEmp.Text = "Correo";
            // 
            // cbed_cargoEmp
            // 
            this.cbed_cargoEmp.FormattingEnabled = true;
            this.cbed_cargoEmp.Items.AddRange(new object[] {
            "Administrativo",
            "Ventas"});
            this.cbed_cargoEmp.Location = new System.Drawing.Point(90, 223);
            this.cbed_cargoEmp.Name = "cbed_cargoEmp";
            this.cbed_cargoEmp.Size = new System.Drawing.Size(444, 21);
            this.cbed_cargoEmp.TabIndex = 13;
            // 
            // txtboxed_salarioEmp
            // 
            this.txtboxed_salarioEmp.Location = new System.Drawing.Point(90, 291);
            this.txtboxed_salarioEmp.Name = "txtboxed_salarioEmp";
            this.txtboxed_salarioEmp.Size = new System.Drawing.Size(162, 20);
            this.txtboxed_salarioEmp.TabIndex = 12;
            // 
            // txtboxed_direccionEmp
            // 
            this.txtboxed_direccionEmp.Location = new System.Drawing.Point(90, 152);
            this.txtboxed_direccionEmp.Name = "txtboxed_direccionEmp";
            this.txtboxed_direccionEmp.Size = new System.Drawing.Size(444, 20);
            this.txtboxed_direccionEmp.TabIndex = 11;
            // 
            // txtboxed_apellidoEmp
            // 
            this.txtboxed_apellidoEmp.Location = new System.Drawing.Point(90, 121);
            this.txtboxed_apellidoEmp.Name = "txtboxed_apellidoEmp";
            this.txtboxed_apellidoEmp.Size = new System.Drawing.Size(444, 20);
            this.txtboxed_apellidoEmp.TabIndex = 10;
            // 
            // txtboxed_nombreEmp
            // 
            this.txtboxed_nombreEmp.Location = new System.Drawing.Point(90, 91);
            this.txtboxed_nombreEmp.Name = "txtboxed_nombreEmp";
            this.txtboxed_nombreEmp.Size = new System.Drawing.Size(444, 20);
            this.txtboxed_nombreEmp.TabIndex = 9;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_actualizar.Location = new System.Drawing.Point(229, 320);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(140, 37);
            this.btn_actualizar.TabIndex = 8;
            this.btn_actualizar.Text = "Guardar Cambios";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // labeled_cargoEmp
            // 
            this.labeled_cargoEmp.AutoSize = true;
            this.labeled_cargoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_cargoEmp.Location = new System.Drawing.Point(16, 224);
            this.labeled_cargoEmp.Name = "labeled_cargoEmp";
            this.labeled_cargoEmp.Size = new System.Drawing.Size(40, 13);
            this.labeled_cargoEmp.TabIndex = 6;
            this.labeled_cargoEmp.Text = "Cargo";
            // 
            // labeled_direccion2Emp
            // 
            this.labeled_direccion2Emp.AutoSize = true;
            this.labeled_direccion2Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_direccion2Emp.Location = new System.Drawing.Point(13, 153);
            this.labeled_direccion2Emp.Name = "labeled_direccion2Emp";
            this.labeled_direccion2Emp.Size = new System.Drawing.Size(61, 13);
            this.labeled_direccion2Emp.TabIndex = 5;
            this.labeled_direccion2Emp.Text = "Direccion";
            // 
            // labeled_apellidoEmp
            // 
            this.labeled_apellidoEmp.AutoSize = true;
            this.labeled_apellidoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_apellidoEmp.Location = new System.Drawing.Point(14, 122);
            this.labeled_apellidoEmp.Name = "labeled_apellidoEmp";
            this.labeled_apellidoEmp.Size = new System.Drawing.Size(52, 13);
            this.labeled_apellidoEmp.TabIndex = 4;
            this.labeled_apellidoEmp.Text = "Apellido";
            // 
            // labeled_nombreEmp
            // 
            this.labeled_nombreEmp.AutoSize = true;
            this.labeled_nombreEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_nombreEmp.Location = new System.Drawing.Point(14, 93);
            this.labeled_nombreEmp.Name = "labeled_nombreEmp";
            this.labeled_nombreEmp.Size = new System.Drawing.Size(50, 13);
            this.labeled_nombreEmp.TabIndex = 3;
            this.labeled_nombreEmp.Text = "Nombre";
            // 
            // btned_consultarEmp
            // 
            this.btned_consultarEmp.BackColor = System.Drawing.Color.DarkGreen;
            this.btned_consultarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btned_consultarEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btned_consultarEmp.Location = new System.Drawing.Point(229, 54);
            this.btned_consultarEmp.Name = "btned_consultarEmp";
            this.btned_consultarEmp.Size = new System.Drawing.Size(140, 31);
            this.btned_consultarEmp.TabIndex = 2;
            this.btned_consultarEmp.Text = "Consultar";
            this.btned_consultarEmp.UseVisualStyleBackColor = false;
            this.btned_consultarEmp.Click += new System.EventHandler(this.btned_consultar_Click);
            // 
            // cbed_codigoEmp
            // 
            this.cbed_codigoEmp.FormattingEnabled = true;
            this.cbed_codigoEmp.Location = new System.Drawing.Point(90, 22);
            this.cbed_codigoEmp.Name = "cbed_codigoEmp";
            this.cbed_codigoEmp.Size = new System.Drawing.Size(444, 21);
            this.cbed_codigoEmp.TabIndex = 1;
            this.cbed_codigoEmp.Text = "-- Seleccione --";
            // 
            // labeled_codigoEmp
            // 
            this.labeled_codigoEmp.AutoSize = true;
            this.labeled_codigoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled_codigoEmp.Location = new System.Drawing.Point(13, 27);
            this.labeled_codigoEmp.Name = "labeled_codigoEmp";
            this.labeled_codigoEmp.Size = new System.Drawing.Size(46, 13);
            this.labeled_codigoEmp.TabIndex = 0;
            this.labeled_codigoEmp.Text = "Codigo";
            // 
            // tp_eliminarEmp
            // 
            this.tp_eliminarEmp.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tp_eliminarEmp.Controls.Add(this.groupBox4Emp);
            this.tp_eliminarEmp.Location = new System.Drawing.Point(4, 22);
            this.tp_eliminarEmp.Name = "tp_eliminarEmp";
            this.tp_eliminarEmp.Size = new System.Drawing.Size(568, 369);
            this.tp_eliminarEmp.TabIndex = 3;
            this.tp_eliminarEmp.Text = "Eliminar";
            // 
            // groupBox4Emp
            // 
            this.groupBox4Emp.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox4Emp.Controls.Add(this.btne_eliminarEmp);
            this.groupBox4Emp.Controls.Add(this.cbe_usuarioEmp);
            this.groupBox4Emp.Controls.Add(this.labele_usuarioEmp);
            this.groupBox4Emp.Location = new System.Drawing.Point(63, 68);
            this.groupBox4Emp.Name = "groupBox4Emp";
            this.groupBox4Emp.Size = new System.Drawing.Size(450, 192);
            this.groupBox4Emp.TabIndex = 0;
            this.groupBox4Emp.TabStop = false;
            // 
            // btne_eliminarEmp
            // 
            this.btne_eliminarEmp.BackColor = System.Drawing.Color.DarkGreen;
            this.btne_eliminarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btne_eliminarEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btne_eliminarEmp.Location = new System.Drawing.Point(174, 115);
            this.btne_eliminarEmp.Name = "btne_eliminarEmp";
            this.btne_eliminarEmp.Size = new System.Drawing.Size(108, 33);
            this.btne_eliminarEmp.TabIndex = 5;
            this.btne_eliminarEmp.Text = "Eliminar";
            this.btne_eliminarEmp.UseVisualStyleBackColor = false;
            this.btne_eliminarEmp.Click += new System.EventHandler(this.btne_eliminarEmp_Click);
            // 
            // cbe_usuarioEmp
            // 
            this.cbe_usuarioEmp.FormattingEnabled = true;
            this.cbe_usuarioEmp.Location = new System.Drawing.Point(118, 53);
            this.cbe_usuarioEmp.Name = "cbe_usuarioEmp";
            this.cbe_usuarioEmp.Size = new System.Drawing.Size(285, 21);
            this.cbe_usuarioEmp.TabIndex = 4;
            this.cbe_usuarioEmp.Text = " -- Seleccione --";
            // 
            // labele_usuarioEmp
            // 
            this.labele_usuarioEmp.AutoSize = true;
            this.labele_usuarioEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labele_usuarioEmp.Location = new System.Drawing.Point(47, 56);
            this.labele_usuarioEmp.Name = "labele_usuarioEmp";
            this.labele_usuarioEmp.Size = new System.Drawing.Size(57, 15);
            this.labele_usuarioEmp.TabIndex = 3;
            this.labele_usuarioEmp.Text = "Usuario";
            // 
            // FormEmpleados
            // 
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(614, 471);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tc_usuariosEmp);
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Empleados";
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

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl tc_usuariosEmp;
        private System.Windows.Forms.TabPage tp_consultarEmp;
        private System.Windows.Forms.GroupBox groupBox1Emp;
        private System.Windows.Forms.Button btnc_limpiarEmp;
        private System.Windows.Forms.ListView litvc_usuarioEmp;
        private System.Windows.Forms.Button btnc_consultarEmp;
        private System.Windows.Forms.ComboBox cbc_codigoEmp;
        private System.Windows.Forms.Label labelc_codigoEmp;
        private System.Windows.Forms.TabPage tp_agregarEmp;
        private System.Windows.Forms.GroupBox groupBox2Emp;
        private System.Windows.Forms.Label labela_direccionEmp;
        private System.Windows.Forms.Label labela_apellidoEmp;
        private System.Windows.Forms.Label labela_nombreEmp;
        private System.Windows.Forms.Button btna_consultarEmp;
        private System.Windows.Forms.TextBox txtboxa_direccionEmp;
        private System.Windows.Forms.TextBox txtboxa_apellidoEmp;
        private System.Windows.Forms.TextBox txtboxa_nombreEmp;
        private System.Windows.Forms.Button btna_guardarEmp;
        private System.Windows.Forms.Label labela_fechaingresoEmp;
        private System.Windows.Forms.TabPage tp_editarEmp;
        private System.Windows.Forms.GroupBox groupBox3Emp;
        private System.Windows.Forms.Label labeled_departamentoEmp;
        private System.Windows.Forms.ComboBox cbed_cargoEmp;
        private System.Windows.Forms.TextBox txtboxed_salarioEmp;
        private System.Windows.Forms.TextBox txtboxed_direccionEmp;
        private System.Windows.Forms.TextBox txtboxed_apellidoEmp;
        private System.Windows.Forms.TextBox txtboxed_nombreEmp;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label labeled_cargoEmp;
        private System.Windows.Forms.Label labeled_direccion2Emp;
        private System.Windows.Forms.Label labeled_apellidoEmp;
        private System.Windows.Forms.Label labeled_nombreEmp;
        private System.Windows.Forms.Button btned_consultarEmp;
        private System.Windows.Forms.ComboBox cbed_codigoEmp;
        private System.Windows.Forms.Label labeled_codigoEmp;
        private System.Windows.Forms.TabPage tp_eliminarEmp;
        private System.Windows.Forms.GroupBox groupBox4Emp;
        private System.Windows.Forms.Button btne_eliminarEmp;
        private System.Windows.Forms.ComboBox cbe_usuarioEmp;
        private System.Windows.Forms.Label labele_usuarioEmp;
        private System.Windows.Forms.Label labelag_duiEmp;
        private System.Windows.Forms.TextBox txtag_duiEmp;
        private System.Windows.Forms.TextBox txtag_cuentabanEmp;
        private System.Windows.Forms.Label labelag_cuentaEmp;
        private System.Windows.Forms.Label labelag_telefonoEmp;
        private System.Windows.Forms.Label labelag_salarioEmp;
        private System.Windows.Forms.TextBox txtag_telefonoEmp;
        private System.Windows.Forms.TextBox txtag_salarioEmp;
        private System.Windows.Forms.Label labelag_correo;
        private System.Windows.Forms.Label labelag_cargoEmp;
        private System.Windows.Forms.TextBox txted_duiEmp;
        private System.Windows.Forms.TextBox txed_codigoEmp;
        private System.Windows.Forms.Label labeled_duiEmp;
        private System.Windows.Forms.Label labeled_codigo2Emp;
        private System.Windows.Forms.Label labeled_ceuntabancariaEmp;
        private System.Windows.Forms.TextBox txted_cuentabancariaEmp;
        private System.Windows.Forms.TextBox txted_telefonoEmp;
        private System.Windows.Forms.Label labeled_telefonoEmp;
        private System.Windows.Forms.Label labeled_salarioEmp;
        private System.Windows.Forms.ComboBox cbag_cargoEmp;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCorreoed_emp;
    }
}