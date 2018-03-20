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
    public partial class RegistrarCliente : Form
    {
        conexion c = new conexion();
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.clienteRegistrado(Convert.ToInt32(clienteId.Text)) == 0)
            {
                MessageBox.Show(c.insertarClinte(Convert.ToInt32(clienteId.Text), nombre.Text, Apellido1.Text, Apellido2.Text, Correo.Text, dateTimePickerNacimiento.Text, Convert.ToInt32(Telefono.Text), Direccion.Text));
            }
            else
            {
                MessageBox.Show("imposible de registrar");
            }
        }
    }
}
