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
    public partial class pedido : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public pedido()
        {
            InitializeComponent();
        }

        public pedido(DataTable grid)
        {
            InitializeComponent();


            dataGridView1.DataSource = grid;
        }

        private void pedido_Load(object sender, EventArgs e)
        {
            conexion c = new conexion();
            c.llenarComboClientes(comboBoxClientes);
            dataGridView1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarCliente open = new RegistrarCliente();
            open.Show();
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            //normalmente se hace así
            using (SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=ProyectoInfo2017;Integrated Security=True"))
            {
                cn.Open();
                string cadcon = "Select * from Clientes where Nombre = '" + comboBoxClientes.Text + "'";
                SqlCommand cdm = new SqlCommand(cadcon,cn);

                dr = cdm.ExecuteReader();

                if (dr.Read() == true)
                {
                    label3.Text = dr["Apellido1"].ToString();
                    label4.Text = dr["Telefono"].ToString();

                }
                else
                {
                    label3.Text = "";
                    label4.Text = string.Empty;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su pedido ha sido confirmado, por favor espere");
            this.Hide();
        }
    }
}
