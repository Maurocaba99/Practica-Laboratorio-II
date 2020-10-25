using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase
{
    class Domicilio
    {
        private String calle;
        private int numero;

        public Domicilio(String calle, int numero)
        {
            this.calle = calle;
            this.numero = numero;
        }

        public String getCalle()
        {
            return calle;
        }

        public int getNumero()
        {
            return numero;
        }

        public void setnumeroCalle(String calle)
        {
            this.calle = calle;
        }
    }
}
