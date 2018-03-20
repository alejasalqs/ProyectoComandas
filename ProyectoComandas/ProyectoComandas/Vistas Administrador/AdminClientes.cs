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
    public partial class AdminClientes : Form
    {
        conexion c = new conexion();
        public AdminClientes()
        {
            InitializeComponent();
        }

        private void AdminClientes_Load(object sender, EventArgs e)
        {
            c.cargarClientes(dgvClientes);
        }

        private void Modificar_Click(object sender, EventArgs e)//boton eliminar
        {
            SqlConnection cn;
            cn = new SqlConnection("Data Source=.;Initial Catalog=ProyectoInfo2017;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("delete from Clientes where IdCliente =" + Convert.ToInt32(this.CedulaBox.Text + ""),cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se elimino el Cliente");
        }

        private void ModificarCedula_TextChanged(object sender, EventArgs e)
        {
            int aux = 0;
            if (int.TryParse(ModificarCedula.Text,out aux)&&c.clienteRegistrado(Convert.ToInt32(ModificarCedula.Text)) > 0)
            {
                c.llenarTextBoxConsulta(Convert.ToInt32(ModificarCedula.Text), ModificarNombre, ModificarApellido1, ModificarApellido2, ModificarTelefono, ModificarDireccion, ModificarCorreo, dateTimeFechaNaci);
                btnModificar.Enabled = true;

            }
            else
            {
                btnModificar.Enabled = false;   
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.modificarCliente(Convert.ToInt32(ModificarCedula.Text), ModificarNombre.Text, ModificarApellido1.Text, ModificarApellido2.Text, ModificarCorreo.Text,dateTimeFechaNaci.Text, ModificarTelefono.Text, ModificarDireccion.Text));
        }
    }
}
