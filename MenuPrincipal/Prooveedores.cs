using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace MenuPrincipal
{
    public partial class Prooveedores : Form
    {
        private SqlConnection connect = new SqlConnection("server=DESKTOP-LPP55BN;database=TIntegrador; Integrated Security=true;");

        public Prooveedores()
        {
            //inizializa el dgv
            InitializeComponent();
            SqlCommand comando = new SqlCommand("SELECT CodProveedor as CodProveedor, Proveedor as Nombre, RazonS as RazonSocial, Cuit, Tel1, Tel2, Calle, Numero, Dto, Mza, Lote, Barrio, Ciudad, Provincia, Cp, Email FROM Proveedores order by CodProveedor desc", connect);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvproveedores.DataSource = tabla;

            dgvproveedores.Columns[0].Width = 100;  //Mercaderia
            dgvproveedores.Columns[1].Width = 120; //Cantidad
            dgvproveedores.Columns[2].Width = 120;  //PU
            dgvproveedores.Columns[3].Width = 75;  //total
            dgvproveedores.Columns[4].Width = 75;
            dgvproveedores.Columns[5].Width = 75;  //Mercaderia
            dgvproveedores.Columns[6].Width = 75; //Cantidad
            dgvproveedores.Columns[7].Width = 60;  //PU
            dgvproveedores.Columns[8].Width = 60;  //total
            dgvproveedores.Columns[9].Width = 60;
            dgvproveedores.Columns[10].Width = 60;
            dgvproveedores.Columns[15].Width = 200;  //Mercaderia
            dgvproveedores.Columns[14].Width = 50; //Cantidad



            dgvproveedores.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvproveedores.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvproveedores.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvproveedores.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvproveedores.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvproveedores.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvproveedores.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvproveedores.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvproveedores.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            Random rdn = new Random();
            int a = rdn.Next(1000, 9999);
            
            label11.Text = a.ToString(); // numero random de la boleta
        }

        private void btn_MostrarDatos_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT CodProveedor as CodProveedor, Proveedor as Nombre, RazonS as RazonSocial, Cuit, Tel1, Tel2, Calle, Numero, Dto, Mza, Lote, Barrio, Ciudad, Provincia, Cp, Email FROM Proveedores order by CodProveedor desc", connect);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvproveedores.DataSource = tabla;

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

            //actualiza los datos de dgv ya escritos
            string query = "UPDATE Proveedores SET   Proveedor=@Proveedor, RazonS=@RazonS, Tel1=@Tel1, Tel2=@Tel2, Calle=@Calle, Numero=@Numero, Dto=@Dto, Mza=@Mza, Lote=@Lote, Barrio=@Barrio,	Ciudad=@Ciudad,Cp=@Cp,Email=@Email where Cuit=@Cuit";
            connect.Open();
            SqlCommand comando = new SqlCommand(query, connect);
            comando.Parameters.AddWithValue("@Cuit", txtdni.Text);
            comando.Parameters.AddWithValue("@CodProveedor", txtnombre.Text);

            comando.Parameters.AddWithValue("@Proveedor", txtapellido1.Text);
            comando.Parameters.AddWithValue("@RazonS", txt_apellido2.Text);
            comando.Parameters.AddWithValue("@Tel1", txttel.Text);
            comando.Parameters.AddWithValue("@Tel2", txttel2.Text);

            comando.Parameters.AddWithValue("@Calle", txtdireccion.Text);
            comando.Parameters.AddWithValue("@Numero", txtnumero.Text);
            comando.Parameters.AddWithValue("@Dto", txtdto.Text);
            comando.Parameters.AddWithValue("@Mza", textmza.Text);
            comando.Parameters.AddWithValue("@Lote", txt_lote.Text);
            comando.Parameters.AddWithValue("@Barrio", textBarrio.Text);

            comando.Parameters.AddWithValue("@Ciudad", txtciudad.Text);
            comando.Parameters.AddWithValue("@Provincia", txtprovincia.Text);
            comando.Parameters.AddWithValue("@Cp", txt_cp.Text);
            comando.Parameters.AddWithValue("@Email", txtEmail.Text);

            comando.ExecuteNonQuery();
            //--------------finaliza y se actualiza dgv

            SqlCommand Actualizar = new SqlCommand("SELECT CodProveedor as CodProveedor, Proveedor as Nombre, RazonS as RazonSocial, Cuit, Tel1, Tel2, Calle, Numero, Dto, Mza, Lote, Barrio, Ciudad, Provincia, Cp, Email FROM Proveedores order by CodProveedor desc", connect);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = Actualizar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvproveedores.DataSource = tabla;
            connect.Close();
            MessageBox.Show("Proveedor Actualizado");


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Elimina los datos cuando colocamos el dni en el campo, eleminia todos los registro del dni
            string query = "DELETE FROM Proveedores WHERE  Cuit=@Cuit";
            connect.Open();
            SqlCommand comando = new SqlCommand(query,connect );
            comando.Parameters.AddWithValue("@Cuit", txtdni.Text);

            comando.ExecuteNonQuery();

            //actualiza dgv
            SqlCommand ELIMINAR = new SqlCommand("SELECT CodProveedor as CodProveedor, Proveedor as Nombre, RazonS as RazonSocial, Cuit, Tel1, Tel2, Calle, Numero, Dto, Mza, Lote, Barrio, Ciudad, Provincia, Cp, Email FROM Proveedores order by CodProveedor desc", connect);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = ELIMINAR;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvproveedores.DataSource = tabla;
           connect.Close();
            MessageBox.Show("Proveedor ELIMINADO");
        }

        private void btn_cargardatos_Click(object sender, EventArgs e)
        {
            // primero valida los datos que sean correctos, de lo contrario, salta mensaje error
            // luego se cargan los datos

            if (txtdni.Text.Equals(""))
            {
                lblDni_clientes.Text = "Este campo es requerido";
                lblDni_clientes.ForeColor = Color.Orange;
                txtdni.Focus();

            }
            else
            {


                if (txtnombre.Text.Equals(""))
                {
                    lblnombre1_clientes.Text = "Este campo es requerido";
                    lblnombre1_clientes.ForeColor = Color.Orange;
                    txtnombre.Focus();

                }
                else
                {
                    if (txtapellido1.Text.Equals(""))
                    {
                        lblApellido.Text = "Este campo es requerido";
                        lblApellido.ForeColor = Color.Orange;
                        txtapellido1.Focus();

                    }
                    else
                    {
                        if (txttel.Text.Equals(""))
                        {
                            lbltel1.Text = "Este campo es requerido";
                            lbltel1.ForeColor = Color.Orange;
                            txttel.Focus();

                        }
                        else
                        {
                            if (txtEmail.Text.Equals(""))
                            {
                                labelemail.Text = "Este campo es requerido";
                                labelemail.ForeColor = Color.Orange;
                                txtEmail.Focus();

                            }
                            else
                            {
                                if (txttel.Text.Equals(""))
                                {
                                    lbltel1.Text = "Este campo es requerido";
                                    lbltel1.ForeColor = Color.Orange;
                                    txttel.Focus();

                                }
                                else
                                {
                                    if (txtprovincia.Text.Equals(""))
                                    {
                                        lblProvincia.Text = "Este campo es requerido";
                                        lblProvincia.ForeColor = Color.Orange;
                                        txtprovincia.Focus();

                                    }
                                    else
                                    {
                                        if (txtciudad.Text.Equals(""))
                                        {
                                            lblciudad.Text = "Este campo es requerido";
                                            lblciudad.ForeColor = Color.Orange;
                                            txtciudad.Focus();

                                        }
                                        else
                                        {
                                            if (lblBarrio.Text.Equals(""))
                                            {
                                                lblBarrio.Text = "Este campo es requerido";
                                                lblBarrio.ForeColor = Color.Orange;
                                                txtciudad.Focus();

                                            }
                                            else
                                            {
                                                if (txtdireccion.Text.Equals(""))
                                                {
                                                    lbldireccion.Text = "Este campo es requerido";
                                                    lbldireccion.ForeColor = Color.Orange;
                                                    txtdireccion.Focus();

                                                }
                                                else
                                                {
                                                    if (txtnumero.Text.Equals(""))
                                                    {
                                                        lblNumero.Text = "Este campo es requerido";
                                                        lblNumero.ForeColor = Color.Orange;
                                                        txtnumero.Focus();

                                                    }
                                                    else
                                                    {
                                                        string query = "INSERT INTO Proveedores (CodProveedor, Cuit, Proveedor , RazonS, Tel1, Tel2, Calle, Numero, Dto, Mza, Lote, Barrio,Ciudad,Cp,Email) VALUES (@CodProveedor, @Cuit, @Proveedor, @RazonS, @Tel1, @Tel2, @Calle, @Numero, @Dto, @Mza, @Lote, @Barrio,@Ciudad,@Cp,@Email)";
                                                        connect.Open();
                                                        SqlCommand comando = new SqlCommand(query, connect);

                                                        comando.Parameters.AddWithValue("@Cuit", txtdni.Text);
                                                        comando.Parameters.AddWithValue("@CodProveedor", txtnombre.Text);
                                                        comando.Parameters.AddWithValue("@Proveedor", txtapellido1.Text);
                                                        comando.Parameters.AddWithValue("@RazonS", txt_apellido2.Text);
                                                        comando.Parameters.AddWithValue("@Tel1", txttel.Text);
                                                        comando.Parameters.AddWithValue("@Tel2", txttel2.Text);
                                                        comando.Parameters.AddWithValue("@Calle", txtdireccion.Text);
                                                        comando.Parameters.AddWithValue("@Numero", txtnumero.Text);
                                                        comando.Parameters.AddWithValue("@Dto", txtdto.Text);
                                                        comando.Parameters.AddWithValue("@Mza", textmza.Text);
                                                        comando.Parameters.AddWithValue("@Lote", txt_lote.Text);
                                                        comando.Parameters.AddWithValue("@Barrio", textBarrio.Text);
                                                        comando.Parameters.AddWithValue("@Ciudad", txtciudad.Text);
                                                        comando.Parameters.AddWithValue("@Cp", txt_cp.Text);
                                                        comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                                                        comando.ExecuteNonQuery();

                                                        SqlCommand insertar = new SqlCommand("SELECT CodProveedor as CodProveedor, Proveedor as Nombre, RazonS as RazonSocial, Cuit, Tel1, Tel2, Calle, Numero, Dto, Mza, Lote, Barrio, Ciudad, Provincia, Cp, Email FROM Proveedores order by CodProveedor desc", connect);
                                                        SqlDataAdapter adaptador = new SqlDataAdapter();
                                                        adaptador.SelectCommand = insertar;
                                                        DataTable tabla = new DataTable();
                                                        adaptador.Fill(tabla);
                                                        dgvproveedores.DataSource = tabla;


                                                        //-........................................

                                                        connect.Close();
                                                        MessageBox.Show("Proveedor Insertado");




                                                    }

                                                }
                                            }

                                        }

                                    }

                                }
                            }


                        }



                    }

                }
            }

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM Proveedores  WHERE Cuit=@Cuit", connect);
            comando.Parameters.AddWithValue("@Cuit", txtrellenar.Text);

            connect.Open();
            SqlDataReader REGISTRO = comando.ExecuteReader();
            if (REGISTRO.Read())
            {

                txtdni.Text = REGISTRO["Cuit"].ToString();
                txtnombre.Text = REGISTRO["CodProveedor"].ToString();
                txtapellido1.Text = REGISTRO["Proveedor"].ToString();
                txt_apellido2.Text = REGISTRO["RazonS"].ToString();
                txttel.Text = REGISTRO["Tel1"].ToString();
                txttel2.Text = REGISTRO["Tel2"].ToString();
                txtdireccion.Text = REGISTRO["Calle"].ToString();
                txtnumero.Text = REGISTRO["Numero"].ToString();
                txtdto.Text = REGISTRO["Dto"].ToString();
                textmza.Text = REGISTRO["Mza"].ToString();
                txt_lote.Text = REGISTRO["Lote"].ToString();
                txt_cp.Text = REGISTRO["Cp"].ToString();
                textBarrio.Text = REGISTRO["Barrio"].ToString();
                txtciudad.Text = REGISTRO["Ciudad"].ToString();
                txtprovincia.Text = REGISTRO["Provincia"].ToString();
                txtEmail.Text = REGISTRO["Email"].ToString();



            }
            connect.Close();


        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CodProveedor as CodProveedor, Proveedor as Nombre, RazonS as RazonSocial, Cuit, Tel1, Tel2, Calle, Numero, Dto, Mza, Lote, Barrio, Ciudad, Provincia, Cp, Email FROM Proveedores where RazonS like ('" + textbuscc.Text + "%')";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dgvproveedores.DataSource = dt;

            connect.Close();




        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            if (txtdni.Text.Equals(""))
            {
                lblDni_clientes.ForeColor = Color.White;
            }
            else
            {
                lblDni_clientes.Text = "*Cuit";
                lblDni_clientes.ForeColor = Color.Yellow;

            }

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text.Equals(""))
            {
                lblnombre1_clientes.ForeColor = Color.White;
            }
            else
            {
                lblnombre1_clientes.Text = "*CodProveedor";
                lblnombre1_clientes.ForeColor = Color.Yellow;

            }

        }

        private void txtapellido1_TextChanged(object sender, EventArgs e)
        {
            if (txtapellido1.Text.Equals(""))
            {
                lblApellido.ForeColor = Color.White;
            }
            else
            {
                lblApellido.Text = "*Proveedor";
                lblApellido.ForeColor = Color.Yellow;

            }

        }

        private void txt_apellido2_TextChanged(object sender, EventArgs e)
        {
            if (txt_apellido2.Text.Equals(""))
            {
                lblapellido2.ForeColor = Color.White;
            }
            else
            {
                lblapellido2.Text = "*Razon social";
                lblapellido2.ForeColor = Color.Yellow;

            }

        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {
            if (txttel.Text.Equals(""))
            {
                lbltel1.ForeColor = Color.White;
            }
            else
            {
                lbltel1.Text = "*Tel 1";
                lbltel1.ForeColor = Color.Yellow;

            }

        }

        private void txttel2_TextChanged(object sender, EventArgs e)
        {
            if (txttel2.Text.Equals(""))
            {
                lbltel2.ForeColor = Color.White;
            }
            else
            {
                lbltel2.Text = "Tel 2";
                lbltel2.ForeColor = Color.Yellow;

            }


        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(""))
            {
                labelemail.ForeColor = Color.White;
            }
            else
            {
                labelemail.Text = "*E-mail";
                labelemail.ForeColor = Color.Yellow;

            }

        }

        private void txtprovincia_TextChanged(object sender, EventArgs e)
        {
            if (txtprovincia.Text.Equals(""))
            {
                lblProvincia.ForeColor = Color.White;
            }
            else
            {
                lblProvincia.Text = "*Provincia";
                lblProvincia.ForeColor = Color.Yellow;

            }

        }

        private void txtciudad_TextChanged(object sender, EventArgs e)
        {
            if (txtciudad.Text.Equals(""))
            {
                lblciudad.ForeColor = Color.White;
            }
            else
            {
                lblciudad.Text = "*Ciudad";
                lblciudad.ForeColor = Color.Yellow;

            }

        }

        private void textBarrio_TextChanged(object sender, EventArgs e)
        {
            if (textBarrio.Text.Equals(""))
            {
                lblBarrio.ForeColor = Color.White;
            }
            else
            {
                lblBarrio.Text = "*Barrio";
                lblBarrio.ForeColor = Color.Yellow;

            }

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtdireccion.Text.Equals(""))
            {
                lbldireccion.ForeColor = Color.White;
            }
            else
            {
                lbldireccion.Text = "*Calle";
                lbldireccion.ForeColor = Color.Yellow;

            }
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            if (txtnumero.Text.Equals(""))
            {
                lblNumero.ForeColor = Color.White;
            }
            else
            {
                lblNumero.Text = "*Numero";
                lblNumero.ForeColor = Color.Yellow;

            }
        }

        private void txtdto_TextChanged(object sender, EventArgs e)
        {
            if (txtdto.Text.Equals(""))
            {
                lblDpto.ForeColor = Color.White;
            }
            else
            {
                lblDpto.Text = "Dto";
                lblDpto.ForeColor = Color.Yellow;

            }

        }

        private void textmza_TextChanged(object sender, EventArgs e)
        {
            if (textmza.Text.Equals(""))
            {
                lblmza.ForeColor = Color.White;
            }
            else
            {
                lblmza.Text = "Mza";
                lblmza.ForeColor = Color.Yellow;

            }

        }

        private void txt_lote_TextChanged(object sender, EventArgs e)
        {
            if (txt_lote.Text.Equals(""))
            {
                lblLote.ForeColor = Color.White;
            }
            else
            {
                lblLote.Text = "Lote";
                lblLote.ForeColor = Color.Yellow;

            }

        }

        private void txt_cp_TextChanged(object sender, EventArgs e)
        {
            if (txt_cp.Text.Equals(""))
            {
                lblCodigoPostal_cliente.ForeColor = Color.White;
            }
            else
            {
                lblCodigoPostal_cliente.Text = "Cp";
                lblCodigoPostal_cliente.ForeColor = Color.Yellow;

            }
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.NumberKeyPress(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.NumberKeyPress(e);
        }

        private void txttel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.NumberKeyPress(e);
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.NumberKeyPress(e);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtdni.Clear();
            txtapellido1.Clear();
            txt_apellido2.Clear();
            txttel.Clear();
            txttel2.Clear();
            txtprovincia.Clear();
            txtciudad.Clear();
            txtEmail.Clear();
            textBarrio.Clear();
            txt_lote.Clear();
            txt_cp.Clear();
            textmza.Clear();
            txtnumero.Clear();
            txtdireccion.Clear();
            txtdto.Clear();
            txtnombre.Clear();
            txtrellenar.Clear();
            textbuscc.Clear();
        }
    }
}
