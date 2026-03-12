using System;
using System.Collections.Generic;

namespace Parcial1Programacion1G2
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Vehículo:");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Anio);
        }

        public virtual void Encender()
        {
            Console.WriteLine("El vehículo se está encendiendo...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("   SISTEMA DE VEHICULOS - PARCIAL   ");
            Console.WriteLine("====================================");
            Console.WriteLine();

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            vehiculos.Add(new Carro("Toyota", "Corolla", 2020, 4));
            vehiculos.Add(new Carro("Honda", "Civic", 2021, 2));
            vehiculos.Add(new Moto("Yamaha", "R6", 2019, 600));
            vehiculos.Add(new Moto("Suzuki", "GN125", 2022, 125));

            int contador = 1;
            foreach (Vehiculo v in vehiculos)
            {
                Console.WriteLine($"----- VEHÍCULO {contador} -----");
                v.MostrarInformacion();
                v.Encender();
                Console.WriteLine();
                contador++;
            }

            Console.WriteLine("====================================");
            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }
    }
}