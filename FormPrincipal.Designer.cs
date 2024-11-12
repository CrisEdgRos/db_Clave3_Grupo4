
namespace Clave3_Grupo4
{
    partial class FormPrincipal
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarPlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesnominasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.planillaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(709, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.menuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoEmpleadosToolStripMenuItem,
            this.mantenimientoDeUsuarioToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.DarkGreen;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.menuToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mantenimientoEmpleadosToolStripMenuItem
            // 
            this.mantenimientoEmpleadosToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.mantenimientoEmpleadosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoEmpleadosToolStripMenuItem.Name = "mantenimientoEmpleadosToolStripMenuItem";
            this.mantenimientoEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.mantenimientoEmpleadosToolStripMenuItem.Text = "Mantenimiento de Empleado";
            this.mantenimientoEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoEmpleadosToolStripMenuItem_Click);
            // 
            // mantenimientoDeUsuarioToolStripMenuItem
            // 
            this.mantenimientoDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.mantenimientoDeUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoDeUsuarioToolStripMenuItem.Name = "mantenimientoDeUsuarioToolStripMenuItem";
            this.mantenimientoDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.mantenimientoDeUsuarioToolStripMenuItem.Text = "Mantenimiento de Usuario";
            this.mantenimientoDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeUsuarioToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearFacturaToolStripMenuItem});
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // crearFacturaToolStripMenuItem
            // 
            this.crearFacturaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.crearFacturaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.crearFacturaToolStripMenuItem.Name = "crearFacturaToolStripMenuItem";
            this.crearFacturaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.crearFacturaToolStripMenuItem.Text = "Crear Factura";
            this.crearFacturaToolStripMenuItem.Click += new System.EventHandler(this.crearFacturaToolStripMenuItem_Click);
            // 
            // planillaToolStripMenuItem
            // 
            this.planillaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.planillaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarPlanillaToolStripMenuItem});
            this.planillaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.planillaToolStripMenuItem.Name = "planillaToolStripMenuItem";
            this.planillaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.planillaToolStripMenuItem.Text = "Planilla";
            // 
            // generarPlanillaToolStripMenuItem
            // 
            this.generarPlanillaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.generarPlanillaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.generarPlanillaToolStripMenuItem.Name = "generarPlanillaToolStripMenuItem";
            this.generarPlanillaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.generarPlanillaToolStripMenuItem.Text = "Generar Planilla";
            this.generarPlanillaToolStripMenuItem.Click += new System.EventHandler(this.generarPlanillaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesnominasToolStripMenuItem});
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesnominasToolStripMenuItem
            // 
            this.reportesnominasToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.reportesnominasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesnominasToolStripMenuItem.Name = "reportesnominasToolStripMenuItem";
            this.reportesnominasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.reportesnominasToolStripMenuItem.Text = "Reportes de Nomina";
            this.reportesnominasToolStripMenuItem.Click += new System.EventHandler(this.reportesnominasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentacionToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // documentacionToolStripMenuItem
            // 
            this.documentacionToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.documentacionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.documentacionToolStripMenuItem.Name = "documentacionToolStripMenuItem";
            this.documentacionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.documentacionToolStripMenuItem.Text = "Documentacion";
            this.documentacionToolStripMenuItem.Click += new System.EventHandler(this.documentacionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.DarkGreen;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::Clave3_Grupo4.Properties.Resources.logo_digipack_2x1;
            this.pictureBox1.Location = new System.Drawing.Point(41, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(709, 429);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesnominasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarPlanillaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}