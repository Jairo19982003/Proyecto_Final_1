using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    internal class SUV : VehiculoBase
    {
        public string Rapido { get; set; }
        public string Seguro { get; set; }
        public string Robusto { get; set; }

        private int Encendido = 0;
        public int Mod_Deportivo = 0;
        public void EncenderSUV()
        {
            if (Encendido == 0)
            {
                base.Encender();
                Console.WriteLine("Se ha encendido su SUV");
                Encendido = 1;
            }
            else
            {
                Console.WriteLine("El Vehiculo ya esta apagado");
            }
        }
        public void Sport_Mod()
        {
            if (Mod_Deportivo == 0)
            {
                Console.WriteLine("Modo Deportivo activado. ");
                Mod_Deportivo = 1;
            }
            else
            {
                Console.WriteLine("El modo deportivo ya esta activado. ");
            }
        }
    }
}
