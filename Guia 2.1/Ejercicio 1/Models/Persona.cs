using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Persona
    {
        public int DNI { get; set; }
        public string NOMBRE { get; set; }

        public Persona(int dni, string nombre) 
        
        {
            DNI = dni;
            NOMBRE = nombre;
        
        }



    }
}
