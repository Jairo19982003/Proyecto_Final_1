using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    internal class _4x4 : VehiculoBase
    {
        public string Duro { get; set; }
        public string Fuerte { get; set; }
        public string Costoso { get; set; }
        public int Encendido = 0;
        public void Encender4x4()
        {
            if (Encendido == 0)
            {
                base.Encender();
                Console.WriteLine("El vehiculo 4x4 se ha encendido");
                Encendido = 1;
            }
            else
            {
                Console.WriteLine("El vehiculo ya esta encendido");
            }
        }
        public void Luces()
        {
            if (Encendido == 1)
            {
                Console.WriteLine("Encender luces");
            }
            else
            {
                Console.WriteLine("No se pueden encer las luces");
            }
        }
    }
}
