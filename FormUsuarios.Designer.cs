
namespace Clave3_Grupo4
{
    partial class FormUsuarios
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
        /// 
 /*       private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.link_menu = new System.Windows.Forms.LinkLabel();
            this.dGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label_clave = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // link_menu
            // 
            this.link_menu.AutoSize = true;
            this.link_menu.Location = new System.Drawing.Point(714, -3);
            this.link_menu.Name = "link_menu";
            this.link_menu.Size = new System.Drawing.Size(77, 13);
            this.link_menu.TabIndex = 27;
            this.link_menu.TabStop = true;
            this.link_menu.Text = "Volver al menu";
            // 
            // dGridViewUsuarios
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridViewUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dGridViewUsuarios.Location = new System.Drawing.Point(247, 25);
            this.dGridViewUsuarios.Name = "dGridViewUsuarios";
            this.dGridViewUsuarios.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridViewUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewUsuarios.Size = new System.Drawing.Size(544, 199);
            this.dGridViewUsuarios.TabIndex = 26;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(520, 242);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(110, 39);
            this.btn_Eliminar.TabIndex = 25;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(373, 242);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(110, 39);
            this.btn_Guardar.TabIndex = 24;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(130, 206);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 23;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(130, 162);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_Usuario.TabIndex = 22;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(130, 118);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 21;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(130, 74);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 20;
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(130, 30);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 19;
            // 
            // label_clave
            // 
            this.label_clave.AutoSize = true;
            this.label_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clave.Location = new System.Drawing.Point(27, 204);
            this.label_clave.Name = "label_clave";
            this.label_clave.Size = new System.Drawing.Size(102, 20);
            this.label_clave.TabIndex = 18;
            this.label_clave.Text = "Contraseña";
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(27, 160);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(71, 20);
            this.label_usuario.TabIndex = 17;
            this.label_usuario.Text = "Usuario";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apellido.Location = new System.Drawing.Point(27, 116);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(73, 20);
            this.label_apellido.TabIndex = 16;
            this.label_apellido.Text = "Apellido";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(27, 72);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(71, 20);
            this.label_nombre.TabIndex = 15;
            this.label_nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 28;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(29, 30);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(25, 20);
            this.label_id.TabIndex = 29;
            this.label_id.Text = "Id";
            // 
            // Form_Usuarios
            // 
            this.ClientSize = new System.Drawing.Size(807, 300);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.link_menu);
            this.Controls.Add(this.dGridViewUsuarios);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label_clave);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form_Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        } */

        #endregion


        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl tc_usuarios;
        private System.Windows.Forms.TabPage tp_consultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnc_limpiar;
        private System.Windows.Forms.ListView litvc_usuario;
        private System.Windows.Forms.Button btnc_consultar;
        private System.Windows.Forms.ComboBox cbc_usuario;
        private System.Windows.Forms.Label labelc_usuario;
        private System.Windows.Forms.TabPage tp_agregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btna_consultar;
        private System.Windows.Forms.TextBox txtboxa_clave;
        private System.Windows.Forms.TextBox txtboxa_usuario;
        private System.Windows.Forms.TextBox txtboxa_apellido;
        private System.Windows.Forms.TextBox txtboxa_nombre;
        private System.Windows.Forms.Button btna_guardar;
        private System.Windows.Forms.Label labela_clave;
        private System.Windows.Forms.TabPage tp_editar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtboxed_clave;
        private System.Windows.Forms.TextBox txtboxed_usuario;
        private System.Windows.Forms.TextBox txtboxed_apellido;
        private System.Windows.Forms.TextBox txtboxed_nombre;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label labeled_clave;
        private System.Windows.Forms.Label labeled_usuario2;
        private System.Windows.Forms.Label labeled_apellido;
        private System.Windows.Forms.Label labeled_nombre;
        private System.Windows.Forms.Button btned_consultar;
        private System.Windows.Forms.ComboBox cbed_usuario;
        private System.Windows.Forms.Label labeled_usuario;
        private System.Windows.Forms.TabPage tp_eliminar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btne_eliminar;
        private System.Windows.Forms.ComboBox cbe_usuario;
        private System.Windows.Forms.Label labele_usuario;
        private System.Windows.Forms.Label labela_usuario;
        private System.Windows.Forms.Label labela_apellido;
        private System.Windows.Forms.Label labela_nombre;
        private System.Windows.Forms.Label labeled_estado;
        private System.Windows.Forms.ComboBox cbed_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_codempleadosa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_codempleadoed;
    }
}