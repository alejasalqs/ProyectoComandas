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
    public partial class ControlOrdenes : Form
    {
        conexion c = new conexion();
        DataTable OrdenesUsuario;
        public ControlOrdenes()
        {
            InitializeComponent();
        }

        private void ControlOrdenes_Load(object sender, EventArgs e)
        {
            
            c.llenarComboPlatos(comboBox1);

            //mostrar configuraciones
            toolstripcalculadoImpuesto.Text = string.Format("Precio se le agrega el {0}%",Configuration.IMPUESTODEVENTA);
            toolstripNotaMeseros.Text = string.Format("Recargo de {0}% para meseros",Configuration.PORCENTAJEMESEROS);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if(comboBox1.SelectedItem != null)
            {
                switch (comboBox1.SelectedItem)
                {
                    case "Agregables":
                        c.cargarAgregables(dgvProductos);
                        break;

                    case "Postres":
                        c.cargarPostre(dgvProductos);
                        break;

                    case "Bebidas":
                        c.cargarBebidas(dgvProductos);
                        break;
                }
            }

        }
        private void pedido_Click(object sender, EventArgs e)
        {
            pedido open = new pedido(OrdenesUsuario);
        
            open.ShowDialog(this);
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidos.Columns.Count == 0)
            {

                dgvPedidos.Columns.Add("idAgregable", "idAgregable");
                dgvPedidos.Columns.Add("Nombre", "Nombre");
                dgvPedidos.Columns.Add("Precio", "Precio");
                dgvPedidos.Columns.Add("Descripción", "Descripción");
                dgvPedidos.Columns.Add("Imagen", "Imagen");//se puede quitar dsepues
                OrdenesUsuario = new DataTable();
                OrdenesUsuario.Columns.Add("idAgregable");
                OrdenesUsuario.Columns.Add("Nombre");
                OrdenesUsuario.Columns.Add("Precio");
                OrdenesUsuario.Columns.Add("Descripción");
                OrdenesUsuario.Columns.Add("Imagen");
                

            }
            //aqui se puede limitar a cuatro pero se peude deajr así
            object[] values = new object[dgvProductos.Rows[e.RowIndex].Cells.Count];
            for (int i = 0; i< dgvProductos.Rows[e.RowIndex].Cells.Count; i++)
            {
                values[i] = dgvProductos.Rows[e.RowIndex].Cells[i].Value;
            }

            dgvPedidos.Rows.Add(values);
            OrdenesUsuario.Rows.Add(values);
        }

        private void dgvPedidos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double precioFinal = 0;
            foreach  (DataGridViewRow currentRow in dgvPedidos.Rows)
            {
                if (currentRow != null)
                {
                    double aux = 0;
                    double.TryParse(currentRow.Cells["Precio"].Value.ToString(), out aux);
                    precioFinal += aux;
                }
            }
            double impuestoTotal = (precioFinal * Configuration.IMPUESTODEVENTA) / 100;
            double paraMeseros = (precioFinal * Configuration.PORCENTAJEMESEROS) / 100;

            lblPrecio.Text = string.Format("Costo  {0} + Impuestos {1} + Comisión Meseros {2} = {3} Colones",precioFinal,impuestoTotal,paraMeseros,(precioFinal+impuestoTotal+paraMeseros));
        }
    }
}
