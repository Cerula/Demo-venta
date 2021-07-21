using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MenuPrincipal
{
     public class eventos
    {
        public void TextKeyPress(KeyPressEventArgs e)
        {



            //este campo es para validar que solo entren letras.
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }

            //este campo es para validar que no entren numeros.
            if (char.IsDigit(e.KeyChar)) { e.Handled = true; }

            //// condicion que nos permite dar un salto de linea cuando se oprime enter
            //else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }

            //condicion que nos permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }

            //condicion que nos permite utilizar la tecla no espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = true; }
            else { e.Handled = false; }


        }

        public void NumberKeyPress(KeyPressEventArgs e)
        {
            //este campo es para validar que solo entren numeros.
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }

            //// condicion que nos permite dar un salto de linea cuando se oprime enter
            //else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }

            //este campo no permiten que ingresen datos de texto
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }

            //condicion que nos permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }

            //condicion que nos permite utilizar la tecla espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = true; }
            else { e.Handled = false; }

        }

        

    }
}
