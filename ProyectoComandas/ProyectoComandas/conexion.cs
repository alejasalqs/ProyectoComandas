using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProyectoComandas
{
    class conexion
    {
        SqlConnection cn; //conexion
        SqlCommand cmd; //enunciado
        SqlDataReader dr; //respuesta
        SqlDataAdapter da;
        DataTable dt;

        public conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=ProyectoInfo2017;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conexion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se conecto a la base por: " + ex.ToString());
            }
        }

        //Insertar en la base de datos
        public string insertarClinte(int IdCliente, string Nombre, string Apellido1, string Apellido2, string Correo, string FechaNacimiento, int Telefono, string Direccion)
        {
            string salida = "si se inserto";
            try
            {
                cmd = new SqlCommand("Insert into Clientes(IdCliente, Nombre, Apellido1, Apellido2, Telefono, Direccion, Correo, FechaNacimiento) values(" + IdCliente + ", '" + Nombre + "', '" + Apellido1 + "', '" + Apellido1 + "', " + Telefono + ", '" + Direccion + "', '" + Correo + "', '" + FechaNacimiento + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se conecto por: " + ex.ToString();
            }
            return salida;
        }


        public int clienteRegistrado(int IdCliente)
        {
            int contador = 0;
            try
            {
                string comandText = "Select * from Clientes where IdCliente = " + IdCliente + " ";
                cmd = new SqlCommand(comandText, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("no se pudo ciclo while");
            }
            return contador;
        }

        public string insertarMesero(int IdMesero, string Nombre, string Apellido1, string Contraseña)
        {
            string salida = "si se inserto";
            try
            {
                cmd = new SqlCommand("Insert into Meseros(IdMesero, Nombre, Apellido1, Contraseña) values(" + IdMesero + ", '" + Nombre + "', '" + Apellido1 + "', " + Contraseña + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se conecto por: " + ex.ToString();
            }
            return salida;
        }

        public int meseroRegistrado(int IdMesero)
        {
            int contador = 0;
            try
            {
                string comandText = "Select * from Meseros where IdMesero = " + IdMesero + " ";
                cmd = new SqlCommand(comandText, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("no se pudo ciclo while");
            }
            return contador;
        }

        public string insertarMesa(int IdMesa, string IdCliente)
        {
            string salida = "si se inserto";
            try
            {
                cmd = new SqlCommand("Insert into Mesas(IdCliente) values(" + IdCliente + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se conecto por: " + ex.ToString();
            }
            return salida;
        }

        public int mesaRegistrada(int IdCliente)
        {
            int contador = 0;
            try
            {
                string comandText = "Select * from Mesas where IdCliente = " + IdCliente + " ";
                cmd = new SqlCommand(comandText, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("no se pudo ciclo while");
            }
            return contador;
        }

        //modificar en la base de datos
        public string modificarCliente(int IdCliente, string Nombre, string Apellido1, string Apellido2, string Correo, string FechaNacimiento, string Telefono, string Direccion)
        {
            string salida = "se actualizaron los datos";
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DBConexion))
                {
                    con.Open();
                    // string query = "update Clientes set Nombre = '" + Nombre + "',  Apellido1= '" + Apellido1 + "', Apellido2 ='" + Apellido2 + "', Correo= '" + Correo + "', FechaNacimiento= '" + FechaNacimiento + "', Telefono= '" + Telefono + "', Direccion= '" + Direccion + "' where IdCliente = '" + IdCliente + "'";
                    string query = @"update Clientes 
                                    set Nombre = @nombre, 
                                        Apellido1= @apellidos, 
                                        Apellido2 =@apellidos2,
                                        Correo= @correo, 
                                        FechaNacimiento= @fechanac,
                                        Telefono= @telefono,
                                         Direccion=@direccion
                    where IdCliente =@identificador";

                    SqlCommand cdm = new SqlCommand(query, con);
                    cdm.Parameters.AddWithValue("@nombre", Nombre);
                    cdm.Parameters.AddWithValue("@apellidos", Apellido1);
                    cdm.Parameters.AddWithValue("@apellidos2", Apellido2);
                    cdm.Parameters.AddWithValue("@correo", Correo);
                    cdm.Parameters.AddWithValue("@fechanac", FechaNacimiento);
                    cdm.Parameters.AddWithValue("@telefono", Telefono);
                    cdm.Parameters.AddWithValue("@direccion", Direccion);
                    cdm.Parameters.AddWithValue("@identificador", IdCliente);

                    int numberOfRows = cdm.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizo por: " + ex.ToString());
            }
            return salida;
        }

        public string modificarMesero(int IdMesero, string Nombre, string Apellido1, string Contraseña)
        {
            string salida = "se actualizaron los datos";
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DBConexion))
                {
                    con.Open();
                    // string query = "update Clientes set Nombre = '" + Nombre + "',  Apellido1= '" + Apellido1 + "', Apellido2 ='" + Apellido2 + "', Correo= '" + Correo + "', FechaNacimiento= '" + FechaNacimiento + "', Telefono= '" + Telefono + "', Direccion= '" + Direccion + "' where IdCliente = '" + IdCliente + "'";
                    string query = @"update Meseros 
                                    set Nombre = @nombre, 
                                        Apellido1= @apellidos, 
                                        Contraseña =@contra
                    where IdMesero =@identificador";

                    SqlCommand cdm = new SqlCommand(query, con);
                    cdm.Parameters.AddWithValue("@nombre", Nombre);
                    cdm.Parameters.AddWithValue("@apellidos", Apellido1);
                    cdm.Parameters.AddWithValue("@contra", Contraseña);
                    cdm.Parameters.AddWithValue("@identificador", IdMesero);

                    int numberOfRows = cdm.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizo por: " + ex.ToString());
            }
            return salida;
        }
        //rellenar textBox
        public void llenarTextBoxConsulta(int IdCliente, TextBox ModificarNombre, TextBox ModificarApellido1, TextBox ModificarApellido2, TextBox ModificarTelefono, TextBox ModificarDireccion, TextBox ModficarCorreo, DateTimePicker dateTimeFechaNaci)
        {
            try
            {
                cmd = new SqlCommand("select * from Clientes where IdCliente = " + IdCliente + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ModificarNombre.Text = dr["Nombre"].ToString();
                    ModificarApellido1.Text = dr["Apellido1"].ToString();
                    ModificarApellido2.Text = dr["Apellido2"].ToString();
                    ModificarTelefono.Text = dr["Telefono"].ToString();
                    ModificarDireccion.Text = dr["Direccion"].ToString();
                    ModficarCorreo.Text = dr["Correo"].ToString();
                    dateTimeFechaNaci.Text = dr["FechaNacimiento"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos por: " + ex.ToString());
            }
        }

        public void llenarTextBoxConsultaMeseros(int IdMesero, TextBox ModificarNombre, TextBox ModificarApellido, TextBox ModificarContra)
        {
            try
            {
                cmd = new SqlCommand("select * from Meseros where IdMesero = " + IdMesero + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ModificarNombre.Text = dr["Nombre"].ToString();
                    ModificarApellido.Text = dr["Apellido1"].ToString();
                    ModificarContra.Text = dr["Contraseña"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos por: " + ex.ToString());
            }
        }

        //cargar informacion  en DataGridView
        public void cargarClientes(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Clientes ", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar por: " + ex.ToString());
            }
        }

        public void cargarMeseros(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Meseros ", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar por: " + ex.ToString());
            }
        }

        public void cargarPlatos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Platos ", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar por: " + ex.ToString());
            }
        }

        public void cargarPostre(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Postres ", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar por: " + ex.ToString());
            }
        }

        public void cargarAgregables(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Agregables ", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar por: " + ex.ToString());
            }
        }

        public void cargarBebidas(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Bebidas ", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar por: " + ex.ToString());
            }
        }

        //Llenar comboBox
        public void llenarComboPlatos(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select * from TipoPlato", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["TipoDePlato"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el combo por: " + ex.ToString());
            }
        }

        public void llenarComboClientes(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select * from Clientes", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Nombre"].ToString());
                }
                cb.SelectedItem = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el combo por: " + ex.ToString());
            }
        }

        public void llenarComboMesas(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select * from Mesas", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["IdMesa"].ToString());
                }
                cb.SelectedItem = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el combo por: " + ex.ToString());
            }
        }

    }
}
