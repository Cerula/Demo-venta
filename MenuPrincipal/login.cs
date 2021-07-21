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
using ClassLibrary1;


namespace MenuPrincipal
{
    public partial class login : Form
    {
       

        public login()
        {
            InitializeComponent();
        }

       
        public static string codigo = "";

        private void textBoxUsuario_KeyUp(object sender, KeyEventArgs e)
        {

            if(textBoxUsuario.Text == "Mati")
            {
                pictureBox1.ImageLocation = "C:/Users/Matias/Downloads/MATICVM.jpg";

            }
            if(textBoxUsuario.Text =="")
            {

                pictureBox1.ImageLocation = "C:/Users/Matias/Downloads/log.png";

            }
            if (textBoxUsuario.Text == "Nico")
            {

                pictureBox1.ImageLocation = "C:/Users/Matias/Downloads/Nico.png";

            }
            if (textBoxUsuario.Text == "Lucas")
            {

                pictureBox1.ImageLocation = "C:/Users/Matias/Downloads/Lucas.jpg";

            }



        }




        private void btnIngresar_Click(object sender, EventArgs e)
        {


            

           
            try
            {

                String CMD = string.Format("SELECT * FROM Usuarios WHERE cuenta='{0}'AND password='{1}'", textBoxUsuario.Text.Trim(), textBoxpassword.Text.Trim());
                DataSet ds = Class1.Ejecutar(CMD);

                codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                String cuenta = ds.Tables[0].Rows[0]["cuenta"].ToString().Trim();
                String Contrasena = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                
                
                if (cuenta == textBoxUsuario.Text.Trim() && Contrasena == textBoxpassword.Text.Trim())
                {

                   
                    MessageBox.Show(" Ha ingresado correctamente al Sistema");

                    this.Hide();//ocultar ventana login
                    MenuPrincipal menuprincipal = new MenuPrincipal();
                    menuprincipal.Show();

                }
               





            }
            catch(Exception)
            {

                MessageBox.Show("Usuario o contraseña incorrecta!...");



            }



            //    if (textBoxUsuario.Text == "Mati" && textBoxpassword.Text == "5555")
            //    {
            //        MessageBox.Show(" Ha ingresado correctamente al Sistema");

            //        this.Hide();//ocultar ventana login
            //        Form1 menuprincipal = new Form1();
            //        menuprincipal.Show();




            //    }
            //    else
            //    {
            //        MessageBox.Show("Error de datos");
            //        textBoxpassword.Text = "";
            //        textBoxUsuario.Text = "";



            //    }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
