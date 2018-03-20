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
    public partial class SeleccionarMesa : Form
    {
        conexion c = new conexion();
        public SeleccionarMesa()
        {
            InitializeComponent();
        }

        private void comboMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=ProyectoInfo2017;Integrated Security=True"))
            {
                cn.Open();
                string cadcon = "Select * from Meseros where IdMesero = '" + comboMesa.Text + "'";
                SqlCommand cdm = new SqlCommand(cadcon, cn);
                SqlDataReader dr;

                dr = cdm.ExecuteReader();

                if (dr.Read() == true)
                {
                    
                    label9.Text = dr["Nombre"].ToString();

                }
                else
                {
                    
                    label9.Text = string.Empty;
                }
            }
        }

        private void SeleccionarMesa_Load(object sender, EventArgs e)
        {
            c.llenarComboMesas(comboMesa);
            c.llenarComboClientes(comboClient);
        }

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=ProyectoInfo2017;Integrated Security=True"))
            {
                cn.Open();
                string cadcon = "Select * from Clientes where Nombre = '" + comboClient.Text + "'";
                SqlCommand cdm = new SqlCommand(cadcon, cn);
                SqlDataReader dr;

                dr = cdm.ExecuteReader();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La reservacion fue exitosa");
            this.Hide();
        }
    }
}
