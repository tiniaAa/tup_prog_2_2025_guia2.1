using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class RegistroVehiculo
    {
        public string Patente { get; set; }
        public string Serie { get; set; }
        public Persona Dueño { get; set; }

        int i;
        public RegistroVehiculo(string serie, string patente,Persona dueño)
        {
            Patente = patente;
            Serie = serie;
            Dueño = dueño;
        }
        public string VerDetalle()
            
        {
            return $"*{Patente}\r\n*{Serie}\r\n*{Dueño.NOMBRE}(Dni:{Dueño.DNI})";
        }


    }
}
