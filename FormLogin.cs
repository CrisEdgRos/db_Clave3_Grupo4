using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clave3_Grupo4;

namespace Clave3_Grupo4
{
    /// <summary>
    /// Formulario Login ingreso de usuario y contraseña
    /// </summary>
    public partial class FormLogin : Form
    {
        Conexion conMysql = new Conexion();
        /// <summary>
        /// Metodo de conexion a Base de Datos de la Clase Conexion a la base de datos
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            try
            {
                conMysql.Connect();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metodo Ingresar
        /// </summary>
        public void ingresar()
        {
            String sql1 = String.Format(@"select nombre, apellido, usuario, clave, codempleado from usuarios where usuario='" + textBox1.Text + "' and clave=aes_encrypt(usuario,'" + textBox2.Text + "')");
            DataRow fila = conMysql.getRow(sql1);
            if (fila != null)
            {
                //Mensaje de Bienvenida al usuario
                usuario usuariog = new usuario() { Usrnombre = fila["nombre"].ToString(), Usrapellido = fila["apellido"].ToString(), Usrusuario = fila["usuario"].ToString(), Usrcodempleado = fila["codempleado"].ToString() };
                MessageBox.Show("!!!... Bienvenido a MiEmpaque " + textBox1.Text + " ...!!!");
                FormPrincipal abrir = new FormPrincipal();
                abrir.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("!!!... Error, usuario y/o contraseña invalidos, verifique ...!!!");
            }
        }

        /// <summary>
        /// Boton cancelar ingreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!... Gracias por usar este software - Clave3 Grupo 4 ...!!!");
            this.Close();
        }
        /// <summary>
        /// Boton Ingresar llama al metodo ingresar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            string usuario, password;
            usuario = textBox1.Text;
            password = textBox2.Text;

            if(usuario == "admin" && password == "admin")
            {
                FormPrincipal abrir = new FormPrincipal();
                abrir.Show();
                this.Hide();
            }
            ingresar();
        }
    }
}
