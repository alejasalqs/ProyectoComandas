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
    public partial class AdminMeseros : Form
    {
        conexion c = new conexion();
        public AdminMeseros()
        {
            InitializeComponent();
        }

        private void AdminMeseros_Load(object sender, EventArgs e)
        {
            conexion c = new conexion();
            c.cargarMeseros(dgvMeseros);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.modificarMesero(Convert.ToInt32(ModificarId.Text), ModificarNombre.Text, ModificarApellido.Text, ModificarContra.Text));
        }

        private void ModificarId_TextChanged(object sender, EventArgs e)
        {
            int aux = 0;
            if (int.TryParse(ModificarId.Text, out aux) && c.clienteRegistrado(Convert.ToInt32(ModificarId.Text)) > 0)
            {
                c.llenarTextBoxConsultaMeseros(Convert.ToInt32(ModificarId.Text), ModificarNombre, ModificarApellido, ModificarContra);
                btnModificar.Enabled = true;

            }
            else
            {
                btnModificar.Enabled = false;
            }
        }

        private void insertar_Click(object sender, EventArgs e)
        {
            if (c.meseroRegistrado(Convert.ToInt32(InsertarId.Text)) == 0)
            {
                MessageBox.Show(c.insertarMesero(Convert.ToInt32(InsertarId.Text), InsertarNombre.Text, InsertarApellido.Text, InsertarContraseña.Text ));
            }
            else
            {
                MessageBox.Show("imposible de registrar");
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            SqlConnection cn;
            cn = new SqlConnection("Data Source=.;Initial Catalog=ProyectoInfo2017;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("delete from Meseros where IdMesero =" + Convert.ToInt32(this.IdMesero.Text + ""), cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se elimino el Mesero");
        }
    }
}
