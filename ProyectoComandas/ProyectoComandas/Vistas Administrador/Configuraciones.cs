using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoComandas.Vistas_Administrador
{
    public partial class Configuraciones : Form
    {
        public Configuraciones()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double aux = 0;
            if(double.TryParse(txtImpuestoVenta.Text,out aux))
            {
                Configuration.IMPUESTODEVENTA = aux;
            }
            if (double.TryParse(txtPorcentajeMeseros.Text, out aux))
            {
                Configuration.PORCENTAJEMESEROS = aux;
            }

            //falta guardar en bd

            MessageBox.Show("Guardadas las configuraciones", "Cambios guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Configuraciones_Load(object sender, EventArgs e)
        {
            txtImpuestoVenta.Text = Configuration.IMPUESTODEVENTA+"";
            txtPorcentajeMeseros.Text = Configuration.PORCENTAJEMESEROS+"";
        }
    }
}
