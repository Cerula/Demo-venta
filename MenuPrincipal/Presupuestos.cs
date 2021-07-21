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
    public partial class Presupuestos : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-LPP55BN;database=TIntegrador; Integrated Security=true;");
        int i = 1;
        
        int posicion;//variable global
        public Presupuestos()
        {
            InitializeComponent();
            tblDatos.Columns[0].Width = 50;  //Mercaderia
            tblDatos.Columns[1].Width = 150; //Cantidad
            tblDatos.Columns[2].Width = 80;  //PU
            tblDatos.Columns[3].Width = 80;  //total
            tblDatos.Columns[4].Width = 80;  //total
            label13.Text = DateTime.Now.ToShortDateString();

            Random rdn = new Random();
            int a = rdn.Next(1000, 9999);

            
            label12.Text = a.ToString(); // numero random de la boleta


        }

        private void form3_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE id_usuario =" + login.codigo;
            DataSet SD;
            SD = ClassLibrary1.Class1.Ejecutar(cmd);


            lblNombreAtiende_presupuesto.Text = SD.Tables[0].Rows[0]["cuenta"].ToString().Trim();

            SqlCommand cm = new SqlCommand(" select *  from Precio ", conexion);
            conexion.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboProducto.Items.Add(dr.GetString(1));


            }
            conexion.Close();

            SqlCommand cf = new SqlCommand(" select * from Clientes", conexion);
            conexion.Open();
            SqlDataReader cr = cf.ExecuteReader();
            while (cr.Read())
            {
                cboClientes.Items.Add(cr.GetString(2));
                // el numero dos indica numero de columnas 

            }
            conexion.Close();


        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            double total = 0; //PARA EL PROMEDIO
            double TotalRegistro;


            string a, b, c, d;
            a = cboProducto.Text;
            b = txtcodpro.Text;
            c = txtprecio.Text;
            d = txtcantidad.Text;


            //suma = Convert.ToDouble(txtcodpro.Text) + Convert.ToDouble(txtprecio.Text) + Convert.ToDouble(txtcantidad.Text) + Convert.ToDouble(Zona1.Text);//Sumar valores
            TotalRegistro = Convert.ToDouble(txtprecio.Text) * Convert.ToDouble(txtcantidad.Text);//Sumar valores
                                                                                                  //sumatoria.Text = Convert.ToString(TotalRegistro);
                                                                                                  //if (TotalRegistro >= 1)
                                                                                                  //{
                                                                                                  //    situacion = "si";
                                                                                                  //}
                                                                                                  // else{
                                                                                                  //     situacion = "error";
                                                                                                  //}



            tblDatos.Rows.Add(i + "", a, b, c, d, TotalRegistro);//convertir en string



            //Recorre el total
            foreach (DataGridViewRow row in tblDatos.Rows)
            {
                total += Convert.ToDouble(row.Cells["tot"].Value);

            }



            lblTotalVentas.Text = Convert.ToString((total));

            //  Suma los totales a medida que se agregan


            i = i + 1;  //LAS CELDADS SE VAYAN AGRAGANDO

            cboProducto.Focus();
        }

        private void tblDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento posicion, capturar donde se da clic(click data grid, (CELLCONTENTCLICK)
            posicion = tblDatos.CurrentRow.Index;
            //MessageBox.Show(posicion+"");, para poder ver la posición.//
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            tblDatos.Rows.RemoveAt(posicion);
            lblTotalVentas.Text = Convert.ToString((0));
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select * from Precio where DESCRIPCION = '" + cboProducto.Text + "'", conexion);
            conexion.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                txtcodpro.Text = dr["CodProducto"].ToString();
                txtprecio.Text = dr["PRECIO"].ToString();
                txtcantidad.Focus();

            }
            conexion.Close();
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select * from clientes where Apellido1 = '" + cboClientes.Text + "'", conexion);
            conexion.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                txtNombre.Text = dr["NOMBRE"].ToString();
                txtdni.Text = dr["DniCliente"].ToString();
                cboProducto.Focus();
            }
            conexion.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNombreAtiende_presupuesto_Click(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            try
            {


                clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();




                Ticket1.TextoCentro("Empresa Por tu Bici "); //imprime una linea de descripcion
                Ticket1.TextoCentro("**********************************");

                Ticket1.TextoIzquierda("Dirección: La Cordillera 4705, Córdoba");
                Ticket1.TextoIzquierda("Tel: 3513941401 ");
                Ticket1.TextoIzquierda("web: www.somosportubici.wixsite.com ");
                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Presupuesto"); //imprime una linea de descripcion
                Ticket1.TextoIzquierda("Presupuesto número: 0000" + label12.Text );
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Le Atendio: " + lblNombreAtiende_presupuesto.Text +"" );
                Ticket1.TextoIzquierda("Presupuesto a nombre de:" + cboClientes.Text + "." +txtNombre.Text);
                Ticket1.TextoIzquierda("");
                clsFactura.CreaTicket.LineasGuion();

                clsFactura.CreaTicket.EncabezadoVenta();
                clsFactura.CreaTicket.LineasGuion();
                ////////////////////////////////////////////////////////////////////
                foreach (DataGridViewRow r in tblDatos.Rows)
                {

                    // PROD                                      //PrECIO                                            CANT                                        TOTAL
                    Ticket1.AgregaArticulo(r.Cells["articulo"].Value.ToString(), int.Parse(r.Cells["Precio"].Value.ToString()), int.Parse(r.Cells["Cantidad"].Value.ToString()), int.Parse(r.Cells["tot"].Value.ToString()));

                    //imprime una linea de descripcion
                    //imprime una linea de descripcion
                    /*Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), int.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()),int.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcionCantidad
                    /*(string Articulo, double precio, int cant, double subtotal)*/




                }


                clsFactura.CreaTicket.LineasGuion();
                //Ticket1.AgregaTotales("Sub-Total", double.Parse("000")); // imprime linea con Subtotal
                //Ticket1.AgregaTotales("Menos Descuento", double.Parse("000")); // imprime linea con decuento total
                //Ticket1.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
                //Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total", double.Parse(lblTotalVentas.Text)); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                //Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(textBox3.Text));
                //Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lbldevolucion.Text));


                // Ticket1.LineasTotales(); // imprime linea 

                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoCentro("*     Gracias por preferirnos    *");

                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer";
                Ticket1.ImprimirTiket(impresora);






            }




            catch (Exception)
            {

                MessageBox.Show("error");



            }
        }

        private void promedio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
