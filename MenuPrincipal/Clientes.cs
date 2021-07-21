using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace MenuPrincipal
{
    public partial class Clientes : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-LPP55BN;database=TIntegrador; Integrated Security=true;");

        public Clientes()
        {
            //inizializa el dgv
            InitializeComponent();
            SqlCommand comando = new SqlCommand("select * from CLIENTES order by DniCliente", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes.DataSource = tabla;


            dgvClientes.Columns[0].Width = 75;  //Mercaderia
            dgvClientes.Columns[1].Width = 120; //Cantidad
            dgvClientes.Columns[2].Width = 120;  //PU
            dgvClientes.Columns[3].Width = 75;  //total
            dgvClientes.Columns[4].Width = 75;
            dgvClientes.Columns[5].Width = 75;  //Mercaderia
            dgvClientes.Columns[6].Width = 75; //Cantidad
            dgvClientes.Columns[7].Width = 60;  //PU
            dgvClientes.Columns[8].Width = 60;  //total
            dgvClientes.Columns[9].Width = 60;
            dgvClientes.Columns[10].Width = 60;
            dgvClientes.Columns[15].Width = 200;  //Mercaderia
            dgvClientes.Columns[14].Width = 50; //Cantidad



            dgvClientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvClientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvClientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvClientes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvClientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvClientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvClientes.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvClientes.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvClientes.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            // Elimina los datos cuando colocamos el dni en el campo, eleminia todos los registro del dni
            string query = "DELETE FROM CLIENTES WHERE  DniCliente= @DniCliente";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@DniCliente", txtdni.Text);

            comando.ExecuteNonQuery();

            //actualiza dgv
            SqlCommand ELIMINAR = new SqlCommand("select * from CLIENTES order by DniCliente ", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = ELIMINAR;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes.DataSource = tabla;
            conexion.Close();
            MessageBox.Show("Cliente ELIMINADO");



        }

        private void dgvClientes_KeyUp(object sender, KeyEventArgs e)
        {
            //Buscador , busca por nombre en el textbox inferior
            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CLIENTES where Nombre like ('" + txtnombre.Text + "%')";
           
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dgvClientes.DataSource = dt;

            conexion.Close();

        }

        private void btn_MostrarDatos_Click(object sender, EventArgs e)
        {
            //actualiza dgv

            SqlCommand comando = new SqlCommand("select * from CLIENTES order by DniCliente", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes.DataSource = tabla;


        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        { //actualiza los datos de dgv ya escritos
            string query = "UPDATE Clientes SET  Nombre=@Nombre, Apellido1=@Apellido1, Apellido2=@Apellido2, Tel1=@Tel1, Tel2=@Tel2, Calle=@Calle, Numero=@Numero, Dto=@Dto, Mza=@Mza, Lote=@Lote, Barrio=@Barrio,	Ciudad=@Ciudad,Cp=@Cp,Email=@Email where DniCliente=@DniCliente";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@DniCliente", txtdni.Text);
            comando.Parameters.AddWithValue("@Nombre", txtnombre.Text);

            comando.Parameters.AddWithValue("@Apellido1", txtapellido1.Text);
            comando.Parameters.AddWithValue("@Apellido2", txt_apellido2.Text);
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

            SqlCommand Actualizar = new SqlCommand("select * from Clientes order by DniCliente", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = Actualizar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes.DataSource = tabla;


            conexion.Close();
            MessageBox.Show("Cliente ACTUALIZADO");




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
            else {


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
                                                        string query = "INSERT INTO Clientes (Nombre, DniCliente, Apellido1, Apellido2, Tel1, Tel2, Calle, Numero, Dto, Mza, Lote, Barrio,Ciudad,Cp,Email) VALUES (@Nombre, @DniCliente, @Apellido1, @Apellido2, @Tel1, @Tel2, @Calle, @Numero, @Dto, @Mza, @Lote, @Barrio,@Ciudad,@Cp,@Email)";
                                                        conexion.Open();
                                                        SqlCommand comando = new SqlCommand(query, conexion);

                                                        comando.Parameters.AddWithValue("@DniCliente", txtdni.Text);
                                                        comando.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                                                        comando.Parameters.AddWithValue("@Apellido1", txtapellido1.Text);
                                                        comando.Parameters.AddWithValue("@Apellido2", txt_apellido2.Text);
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

                                                        SqlCommand insertar = new SqlCommand("select * from Clientes order by DniCliente", conexion);
                                                        SqlDataAdapter adaptador = new SqlDataAdapter();
                                                        adaptador.SelectCommand = insertar;
                                                        DataTable tabla = new DataTable();
                                                        adaptador.Fill(tabla);
                                                        dgvClientes.DataSource = tabla;


                                                        //-........................................

                                                        conexion.Close();
                                                        MessageBox.Show("Cliente Insertado");




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
          


            //---------------------------------------
            
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            //rellenar los campos atraves del dni
            SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTES WHERE DniCliente=@DniCliente", conexion);
            comando.Parameters.AddWithValue("@DniCliente", txtrellenar.Text);

            conexion.Open();
            SqlDataReader REGISTRO = comando.ExecuteReader();
            if (REGISTRO.Read())
            {
                
                txtdni.Text= REGISTRO["DniCliente"].ToString();
                txtnombre.Text = REGISTRO["Nombre"].ToString();
                txtapellido1.Text = REGISTRO["Apellido1"].ToString();
                txt_apellido2.Text = REGISTRO["Apellido2"].ToString();
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
            conexion.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CLIENTES where Apellido1 like ('" + textBuscar .Text+ "%')";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dgvClientes.DataSource = dt;

            conexion.Close();

        }

       

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            if (txtdni.Text.Equals(""))
            {
               lblDni_clientes.ForeColor = Color.White;
            }
            else
            {
                lblDni_clientes.Text = "*DNI";
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
                lblnombre1_clientes.Text = "*Nombre 1";
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
                lblApellido.Text = "*Apellido 1";
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
                lblapellido2.Text = "Apellido 2";
                lblapellido2.ForeColor = Color.Yellow;

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
                lbldireccion.Text = "*Direccion";
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

        private void txtapellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.TextKeyPress(e);
        }

        private void txt_apellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.TextKeyPress(e);
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

    
        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.NumberKeyPress(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.TextKeyPress(e);
        }
         void limpiar()
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
            textBuscar.Clear();




        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.NumberKeyPress(e);
        }
    }
}
