using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipal
{
    class Cliente
    {
        public Cliente()
        {

        }

        private int DniCliente;
        private String NOMBRE;
        private String Apellido1;
        private String Apellido2;
        private int Tel1;
        private int Tel2;
        private String Calle;
        private int Numero;
        private String Dto;
        private String Mza;
        private String Lote;
        private String Barrio;
        private String Ciudad;
        private String Provincia;
        private int Cp;
        private String Email;




        public int DNI_cliente
        {
            get
            {
                return DniCliente;
            }

            set
            {
                DniCliente = value;
            }
        }

        public string Nombre
        {
            get
            {
                return NOMBRE;
            }

            set
            {
               NOMBRE = value;
            }
        }

        public string Apellido01
        {
            get
            {
                return Apellido1;
            }

            set
            {
                Apellido1 = value;
            }
        }

        public string Apellido02
        {
            get
            {
                return Apellido2;
            }

            set
            {
                Apellido2 = value;
            }
        }

        public int Tele01
        {
            get
            {
                return Tel1;
            }

            set
            {
                Tel1 = value;
            }
        }

        public int Tele02
        {
            get
            {
                return Tel2;
            }

            set
            {
                Tel2 = value;
            }
        }
        public string CALLE
        {
            get
            {
                return Calle;
            }

            set
            {
                Calle = value;
            }
        }
        public int NUMERO
        {
            get
            {
                return Numero;
            }

            set
            {
                Numero = value;
            }
        }

        public string Departamento
        {
            get
            {
                return Dto;
            }

            set
            {
                Dto = value;
            }
        }

        public string MANZANA
        {
            get
            {
                return Mza;
            }

            set
            {
                Mza = value;
            }
        }
        public string LOTE
        {
            get
            {
                return Lote;
            }

            set
            {
                Lote = value;
            }
        }

        public string BARRIO
        {
            get
            {
                return Barrio;
            }

            set
            {
                Barrio = value;
            }
        }

        public string CIUDAD
        {
            get
            {
                return CIUDAD;
            }

            set
            {
                Ciudad = value;
            }
        }

        public string PROVINCIA
        {
            get
            {
                return Provincia;
            }

            set
            {
                Provincia = value;
            }
        }
        public int CODIGOP
        {
            get
            {
                return Cp;
            }

            set
            {
                Cp = value;
            }
        }
        public string EMAIL
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }





    }
}
