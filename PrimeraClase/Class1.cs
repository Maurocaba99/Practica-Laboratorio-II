using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase
{
    class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public String getNombre()
        {
            return nombre;
        }

        public String getApellido()
        {
            return apellido;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setApellido(String apellido)
        {

            this.apellido = apellido;

        }
         
         public void getdomicilio(String apellido)
        { 
            this.apellido = apellido;

        }
    public void caminar()
        {

        }
        public int estudiar()
        {
            return 1;
        }
    } 
}
