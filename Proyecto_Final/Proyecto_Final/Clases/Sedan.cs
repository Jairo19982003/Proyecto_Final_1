using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    internal class Sedan: VehiculoBase
    {
        public string Tablero { get; set; }
        public string Sillones { get; set; }
        public string AireAcondicionado { get; set; }

        private int Encendido = 0;

        private int baul = 0;
        public void EncenderSedan()
        {
            if (Encendido == 0)
            {
                base.Encender();
                Console.WriteLine("Su sedan se ha encendido");
                Encendido = 1;
            }
            else
            {
                Console.WriteLine("Su sedan esta apagado");
            }
        }
        public void Abrir_baul()
        {
            if (baul == 0)
            {
                Console.WriteLine("Abir baul");
                baul = 1;
            }
            else
            {
                Console.WriteLine("El baul ya esta abierto");
            }
        }
        public void Cerrar_baul()
        {
            if (baul == 1)
            {
                Console.WriteLine("Cerrar bahul");
                baul = 0;
            }
            else
            {
                Console.WriteLine("El baul ya esta cerrado");
            }
        }

        public void Act_Aire_Acondicionado()
        {
            if (Encendido == 1)
            {
                Console.WriteLine("El aire acondicionado se ha encendido. ");
            }
            else
            {
                Console.WriteLine("El aire acondicionado esta apagodo. ");
            }
        }

        public void Quema_cocos()
        {
            int activacion = 0;
            if (activacion == 0)
            {
                Console.WriteLine("Se activo el Quema cocos disfruta del aire fresco. ");
                activacion = 1;
            }
            else
            {
                Console.WriteLine("El Quema cocos esta desactivado. ");
            }
        }
    }
}
