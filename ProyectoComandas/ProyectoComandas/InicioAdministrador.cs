using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoComandas
{
    public partial class InicioAdministrador : Form
    {
        public InicioAdministrador()
        {
            InitializeComponent();
        }

        private void administrarMeserosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMeseros open = new AdminMeseros();
            open.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void administrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminClientes open = new AdminClientes();
            open.Show();
        }

        private void administrarOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminOrdenes open = new AdminOrdenes();
            open.Show();
        }
    }
}
