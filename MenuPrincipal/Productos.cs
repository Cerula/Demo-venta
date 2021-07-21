using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MenuPrincipal
{
    public partial class Productos : Form
    { 
        private SqlConnection connect = new SqlConnection("server=DESKTOP-LPP55BN;database=TIntegrador; Integrated Security=true;");
        public Productos()
        {
            InitializeComponent();
            
            
            SqlCommand comando = new SqlCommand("select DESCRIPCION as Producto, STOCK as Stock,  precio as Precio, CodProveedor as CodProv, CodProducto as CodProd from Precio ", connect);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvProductos.DataSource = tabla;
            dgvProductos.Columns[0].Width = 350;  
            dgvProductos.Columns[1].Width =100; //Cantidad
            dgvProductos.Columns[2].Width = 100;  //PU
            dgvProductos.Columns[3].Width = 100;  //total
            dgvProductos.Columns[4].Width = 100;
            

            dgvProductos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                MessageBox.Show("conectado");
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR");

            }

        }

        private void btn_MostrarDatos_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select DESCRIPCION as Producto, STOCK as Stock,  precio as Precio, CodProveedor as CodProv, CodProducto as CodProd from Precio", connect);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvProductos.DataSource = tabla;
            dgvProductos.Columns[3].Width = 100;

            dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Precio SET precio=@precio, STOCK=@STOCK, CodProveedor=@CodProveedor,  CodProducto=@CodProducto WHERE DESCRIPCION=@DESCRIPCION";
            connect.Open();
            SqlCommand comando = new SqlCommand(query, connect);
            comando.Parameters.AddWithValue("@DESCRIPCION", txtproducto.Text);
            comando.Parameters.AddWithValue("@precio", txtprecio.Text);
            comando.Parameters.AddWithValue("@STOCK", txtstock.Text);
            comando.Parameters.AddWithValue("@CodProveedor", txtCodproveedor.Text);
            comando.Parameters.AddWithValue("@CodProducto", txtcodproducto.Text);

            comando.ExecuteNonQuery();
                
            //---------------------------------------
            SqlCommand Actualizar = new SqlCommand("select DESCRIPCION as Producto, STOCK as Stock,  precio as Precio, CodProveedor as CodProv, CodProducto as CodProd from Precio", connect);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = Actualizar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvProductos.DataSource = tabla;

            dgvProductos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //-........................................





            connect.Close();
            MessageBox.Show("Producto ACTUALIZADO");
        }

        private void btn_cargardatos_Click(object sender, EventArgs e)
        {

            if (txtproducto.Text.Equals(""))
            {
                lblProducto.Text = "Este campo es requerido";
                lblProducto.ForeColor = Color.Orange;
                txtproducto.Focus();

            }
            else
            {
                if (txtcodproducto.Text.Equals(""))
                {

                    Lblcodproducto.Text = "Este campo es requerido";
                    Lblcodproducto.ForeColor = Color.Orange;
                    txtcodproducto.Focus();



                }
                else {
                    if (txtprecio.Text.Equals(""))
                    {

                        lblprecio.Text = "Este campo es requerido";
                        lblprecio.ForeColor = Color.Orange;
                        txtprecio.Focus();

                    }
                    else
                    {

                        if (txtstock.Text.Equals(""))
                        {

                            lblstock.Text = "Este campo es requerido";
                            lblstock.ForeColor = Color.Orange;
                            txtstock.Focus();

                        }
                        else
                        {

                            if (txtCodproveedor.Text.Equals(""))
                            {

                               lblcodprovvedor.Text = "Este campo es requerido";
                                lblcodprovvedor.ForeColor = Color.Orange;
                                txtCodproveedor.Focus();

                            }
                            else
                            {
                                string query = "INSERT INTO Precio (DESCRIPCION,precio,STOCK,CodProveedor,CodProducto) VALUES (@DESCRIPCION,@precio,@STOCK,@CodProveedor,@CodProducto)";
                                connect.Open();
                                SqlCommand comando = new SqlCommand(query, connect);
                                comando.Parameters.AddWithValue("@DESCRIPCION", txtproducto.Text);
                                comando.Parameters.AddWithValue("@precio", txtprecio.Text);
                                comando.Parameters.AddWithValue("@STOCK", txtstock.Text);
                                comando.Parameters.AddWithValue("@CodProveedor", txtCodproveedor.Text);
                                comando.Parameters.AddWithValue("@CodProducto", txtcodproducto.Text);

                                comando.ExecuteNonQuery();


                                //---------------------------------------
                                SqlCommand CARGA = new SqlCommand("select DESCRIPCION as Producto, STOCK as Stock,  precio as Precio, CodProveedor as CodProv, CodProducto as CodProd  from Precio", connect);
                                SqlDataAdapter adaptador = new SqlDataAdapter();
                                adaptador.SelectCommand = CARGA;
                                DataTable tabla = new DataTable();
                                adaptador.Fill(tabla);
                                dgvProductos.DataSource = tabla;

                                dgvProductos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dgvProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dgvProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                                //-........................................

                                connect.Close();
                                MessageBox.Show("Producto Insertado");







                            }




                        }





                    }
                }




            }
            
            
            





            //string query = "INSERT INTO Precio (DESCRIPCION,precio,STOCK,CodProveedor,CodProducto) VALUES (@DESCRIPCION,@precio,@STOCK,@CodProveedor,@CodProducto)";
            //connect.Open();
            //SqlCommand comando = new SqlCommand(query, connect);
            //comando.Parameters.AddWithValue("@DESCRIPCION", txtproducto.Text);
            //comando.Parameters.AddWithValue("@precio", txtprecio.Text);
            //comando.Parameters.AddWithValue("@STOCK", txtstock.Text);
            //comando.Parameters.AddWithValue("@CodProveedor", txtCodproveedor.Text);
            //comando.Parameters.AddWithValue("@CodProducto", txtcodproducto.Text);

            //comando.ExecuteNonQuery();


            ////---------------------------------------
            //SqlCommand CARGA = new SqlCommand("select DESCRIPCION, STOCK,  precio, CodProveedor from Precio", connect);
            //SqlDataAdapter adaptador = new SqlDataAdapter();
            //adaptador.SelectCommand = CARGA;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dgvProductos.DataSource = tabla;


            ////-........................................

            //connect.Close();
            //MessageBox.Show("Producto Insertado");
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Precio WHERE  CodProducto=@CodProducto";
            connect.Open();
            SqlCommand comando = new SqlCommand(query, connect);
            comando.Parameters.AddWithValue("@CodProducto", txtcodproducto.Text);

            comando.ExecuteNonQuery();

            //---------------------------------------
            SqlCommand ELIMINAR = new SqlCommand("select DESCRIPCION as Producto, STOCK as Stock,  precio as Precio, CodProveedor as Codigo, CodProducto as CodProd from Precio", connect);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = ELIMINAR;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvProductos.DataSource = tabla;

            dgvProductos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //-........................................


            connect.Close();
            MessageBox.Show("Producto ELIMINADO");
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            // se rellena los campos apartir de completar el codigo y apretas boton buscar

            SqlCommand comando = new SqlCommand("SELECT * FROM Precio WHERE  CodProducto= @CodProducto", connect);
            comando.Parameters.AddWithValue("@CodProducto", txtcodproducto.Text);


            connect.Open();
            SqlDataReader REGISTRO = comando.ExecuteReader();
            if (REGISTRO.Read())
            {
                txtproducto.Text = REGISTRO["DESCRIPCION"].ToString();
             txtprecio.Text = REGISTRO["precio"].ToString();
              txtCodproveedor.Text= REGISTRO["CodProveedor"].ToString();
                txtstock.Text= REGISTRO["STOCK"].ToString();
                txtcodproducto.Text= REGISTRO["CodProducto"].ToString();
            }
            connect.Close();


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productos_KeyUp(object sender, KeyEventArgs e)
        {
            //connect.Open();
            //SqlCommand comand = connect.CreateCommand();
            //comand.CommandType = CommandType.Text;
            //comand.CommandText = "SELECT* FROM PRECIOS$ where REPUESTOS like ('" + txtproducto + "%')";
            //comand.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter adaptador = new SqlDataAdapter(comand);
            //adaptador.Fill(dt);
            //dgvProductos.DataSource = (dt);
            //connect.Close();


            //connect.Open();

            //SqlCommand cmd = connect.CreateCommand();

            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT* FROM PRECIOS$ where PRECIO like ('" + txtMarcabuscar.Text + "%')";
            //cmd.ExecuteNonQuery();

            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);

            //da.Fill(dt);

            //dgvProductos.DataSource = dt;

            //connect.Close();
        }

        private void txtproducto_KeyUp(object sender, KeyEventArgs e)
        {
           

        }

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {
            if (txtproducto.Text.Equals(""))
            {
                lblProducto.ForeColor = Color.White;
            }
            else
            {
                lblProducto.Text = "*Producto";
                lblProducto.ForeColor = Color.Yellow;

            }
        }

        private void TxtBuscProducto_KeyUp(object sender, KeyEventArgs e)
        {
            connect.Open();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select DESCRIPCION as Producto, STOCK as Stock,  precio as Precio, CodProveedor as CodProv, CodProducto as CodProd from Precio where DESCRIPCION like ('" + TxtBuscProducto.Text + "%')";
          
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dgvProductos.DataSource = dt;

            connect.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            connect.Open();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select  DESCRIPCION as Producto, STOCK as Stock,  precio as Precio, CodProveedor as CodProv, CodProducto as CodProd  FROM Precio  WHERE STOCK<=0" + (textCantidad.Text) + " order by Stock desc";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dgvProductos.DataSource = dt;
            dgvProductos.Columns[3].Width = 100;  //total

            dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            connect.Close();




        }

       

        private void btnproveedor_Click(object sender, EventArgs e)
        {

            // "SELECT * FROM Precio WHERE  CodProveedor="+txtCodproveedor.Text +"";

            //connect.Open();
            //dgvProductos.DataSource= "select DESCRIPCION,STOCK, CodProveedor  from precio WHERE CodProveedor =" + (textCantidad.Text) + " order by Stock desc";
            //connect.Close();

        }

        private void txtproveedorProduc_KeyUp(object sender, KeyEventArgs e)
        {
            connect.Open();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  DESCRIPCION as Producto, STOCK as Stock,  precio as Precio, CodProveedor as CodProv, CodProducto as CodProd  FROM Precio WHERE CodProveedor LIKE'" + (TXTcODpRO.Text) + "%'";
            //SELECT DESCRIPCION,STOCK,CodProveedor FROM Precio where CodProveedor like '2005%'

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dgvProductos.DataSource = dt;
            dgvProductos.Columns[3].Width = 100;  //total

            dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            connect.Close();
        }

        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            connect.Open();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  DESCRIPCION as Producto, STOCK as Stock,  precio as Precio, CodProveedor as CodProv, CodProducto as CodProd  FROM Precio WHERE CodProveedor LIKE'" + (txtMenos25.Text) + "%'AND STOCK<= 25";
            

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dgvProductos.DataSource = dt;
            dgvProductos.Columns[3].Width = 100;  //total

            dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            connect.Close();



        }

        private void txtmenos100_KeyUp(object sender, KeyEventArgs e)
        {
            connect.Open();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  DESCRIPCION as Producto, STOCK as Stock,  precio as Precio, CodProveedor as CodProv, CodProducto as CodProd  FROM Precio WHERE CodProveedor LIKE'" + (txtmenos100.Text) + "%'AND STOCK<= 100";
            

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dgvProductos.DataSource = dt;
            dgvProductos.Columns[3].Width = 100;  

            dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            connect.Close();

        }

        private void txtmenos10_KeyUp(object sender, KeyEventArgs e)
        {
            connect.Open();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  DESCRIPCION as Producto, STOCK as Stock,  precio as Precio, CodProveedor as Codigo,CodProducto as CodProd  FROM Precio WHERE CodProveedor LIKE'" + (txtmenos10.Text) + "%'AND STOCK<= 10";
            dgvProductos.Columns[0].Width = 350;  //Mercaderia
            dgvProductos.Columns[1].Width = 100; //Cantidad
            dgvProductos.Columns[2].Width = 100;  //PU
            dgvProductos.Columns[3].Width = 100;  //total

            dgvProductos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dgvProductos.DataSource = dt;

            connect.Close();
        }

        private void txtcodproducto_TextChanged(object sender, EventArgs e)
        {
            if (txtcodproducto.Text.Equals(""))
            {
                Lblcodproducto.ForeColor = Color.White;
            }
            else
            {
               Lblcodproducto.Text = "*CodProducto";
                Lblcodproducto.ForeColor = Color.Yellow;

            }
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            if (txtprecio.Text.Equals(""))
            {
                lblprecio.ForeColor = Color.White;
            }
            else
            {
                lblprecio.Text = "*Precio";
                lblprecio.ForeColor = Color.Yellow;

            }
        }

        private void txtstock_TextChanged(object sender, EventArgs e)
        {
            if (txtstock.Text.Equals(""))
            {
                lblstock.ForeColor = Color.White;
            }
            else
            {
                lblstock.Text = "*Stock";
                lblstock.ForeColor = Color.Yellow;

            }

        }

        private void txtCodproveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtCodproveedor.Text.Equals(""))
            {
                lblcodprovvedor.ForeColor = Color.White;
            }
            else
            {
                lblcodprovvedor.Text = "*CodProveedor";
                lblcodprovvedor.ForeColor = Color.Yellow;

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtcodproducto.Clear();
            txtprecio.Clear();
           txtproducto.Clear();
            txtstock.Clear();
            txtCodproveedor.Clear();
        }

        private void txtcodproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.NumberKeyPress(e);
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.NumberKeyPress(e);
        }

        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.NumberKeyPress(e);
        }

        private void txtCodproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            objectscs.Eventos.NumberKeyPress(e);
        }
    }
}
