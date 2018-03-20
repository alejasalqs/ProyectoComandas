using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoComandas
{
    public partial class InicioAdmin : Form
    {
        conexion c = new conexion();
        SqlConnection cn;
        public InicioAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void iniciarSesion(string Nombre)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("select Nombre, Contraseña from Meseros where Nombre = @Nombre", cn);
                cmd.Parameters.AddWithValue("Nombre", Nombre);
                //cmd.Parameters.AddWithValue("contrasña", contraseña);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    new InicioAdministrador().Show();
                }
                else
                {
                    MessageBox.Show("usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hubo un error al iniciar sesion por: " + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            InicioAdministrador open = new InicioAdministrador();
            open.Show();

            this.Hide();


        }
    }
}
