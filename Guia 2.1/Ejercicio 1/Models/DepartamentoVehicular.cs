using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class DepartamentoVehicular
    {
        public int CantidadRegistros { get {return registros.Count; } }

        ArrayList registros = new ArrayList();
        
        
        int nroRegistro;
        int nroSerie;
        static Random RND = new Random();

        public RegistroVehiculo RegistrarVehiculo(Persona propietario)
        {

            string patente = GenerarPatente();
            string serie = nroSerie++.ToString("0000000");
            RegistroVehiculo nuevoVehiculo =new  RegistroVehiculo(serie, patente, propietario);

            registros.Add(nuevoVehiculo);

            return nuevoVehiculo;
        }
        public RegistroVehiculo VerRegistro(int idx)
        {
            if (idx>=0 && idx <registros.Count)
            {
                return registros[idx] as RegistroVehiculo;
            }

            return null ;
        }

        public string GenerarPatente()
        {

            char letra1 = (char)RND.Next('A', 'Z' + 1);
            char letra2 = (char)RND.Next('A', 'Z' + 1);

            string patente = $"{letra1}{letra1} {nroRegistro++:000}";



            return patente; 
        }


    }
}
