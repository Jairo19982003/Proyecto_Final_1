using Proyecto_Final.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    internal class VehiculoBase:IVehiculos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; }
        public int VelocidadActual { get; }
        private int Encendido = 0;
        public void Bocina()
        {
            if (Encendido == 1)
            {
                Console.WriteLine("Peep, Peep");
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
        public void Acelerar(int cuanto)
        {
            if (Encendido == 1)
            {
                Console.WriteLine($"vas a {cuanto}");
            }
            else
            {
                Console.WriteLine("El vehiculo se encuentra apagado");
            }
        }
        public void Velocidades(int VelocidadActual, int VelocidadMaxima)
        {
            VelocidadActual = VelocidadActual;
            VelocidadMaxima = VelocidadMaxima;
            Console.WriteLine("La velocidad maxima es de: " + VelocidadMaxima);
            if (Encendido == 1 && (VelocidadActual <= VelocidadMaxima))
            {
                Console.WriteLine("La Velocidad actual es de: " + VelocidadActual);
            }
            else if (Encendido == 1 && (VelocidadActual > VelocidadMaxima))
            {
                Console.WriteLine("El vehiculo no puede sobrepasar esta velocidad. ");
            }
            else
            {
                Console.WriteLine("El vehiculo no puede acelerar porque esta apagado ");
            }
        }
        public void Encender()
        {
            if (Encendido == 0)
            {
                Console.WriteLine("Bienvenido a tu nuevo Vehiculo. ");
                Encendido = 1;
            }
            else
            {
                Console.WriteLine("cuidado, el vehiculo ya estaba encendido. ");
            }
        }
        public void Apagar()
        {
            if (Encendido == 1)
            {
                Console.WriteLine("tu vehiculo se ha apago. ");
                Encendido = 0;
            }
            else
            {
                Console.WriteLine("El vehiculo ya estaba apagado. ");
            }
        }


        public void Frenar(int cuanto)
        {
            if (Encendido == 1)
            {
                Console.WriteLine($"Se freno con una fuerza de {cuanto}");
            }
            else
            {
                Console.WriteLine($"Se freno con una fuerza de {cuanto}");
            }
        }

    }
}
