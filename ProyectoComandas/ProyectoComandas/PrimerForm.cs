using ProyectoComandas.Vistas_Administrador;
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
    public partial class PrimerForm : Form
    {
        public PrimerForm()
        {
            InitializeComponent();
        }

        private void editarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCliente open = new RegistrarCliente();
            open.Show();
        }

        private void listaTotalDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioAdmin open = new InicioAdmin();
            open.Show();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarMesa open = new SeleccionarMesa();
            open.Show();
        }

        private void meserosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meseros open = new Meseros();
            open.Show();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlOrdenes open = new ControlOrdenes();
            open.Show();
        }

        private void PrimerForm_Load(object sender, EventArgs e)
        {
            conexion c = new conexion();
           // c.cargarClientes(dvgClientes);
        }

        private void configuracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuraciones configForm = new Configuraciones();
            configForm.ShowDialog(this);
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
                InicioAdmin open = new InicioAdmin();
                open.Show();
            

        }
    }
}
