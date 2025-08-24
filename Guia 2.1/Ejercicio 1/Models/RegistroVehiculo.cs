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

        public RegistroVehiculo(string serie, string patente)
        {
            Patente = patente;
            Serie = serie;
        }
        public string VerDetalle()
            
        {
            return $"{Patente}-{Serie}";
        }


    }
}
