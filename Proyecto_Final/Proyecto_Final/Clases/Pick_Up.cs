using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    internal class Pick_Up: VehiculoBase
    {
        public string Llantas { get; set; }
        public string Motor { get; set; }
        public string Radio { get; set; }
        public string CapacidadCarga { get; set; }
        public int Es_4x4 { get; set; }

        private int Encendido = 0;
        public void Encender1()
        {
            base.Encender();
            Console.WriteLine("Bienvenido a tu vehiculo. ");
            Encendido = 1;
        }
        public void FourWeelTraction()
        {
            if (Es_4x4 == 1)
            {
                Console.WriteLine("La traccion 4x4 esta activada. ");
            }
            else
            {
                Console.WriteLine("No se puede activar la traccion 4x4. ");
            }
        }
    }
}
