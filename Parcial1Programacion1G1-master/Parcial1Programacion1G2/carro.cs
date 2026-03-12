using System;

namespace Parcial1Programacion1G2
{
    public class Carro : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        public Carro(string marca, string modelo, int anio, int numeroPuertas) 
            : base(marca, modelo, anio)
        {
            NumeroPuertas = numeroPuertas;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de puertas: {NumeroPuertas}");
        }

        public override void Encender()
        {
            Console.WriteLine("El carro está encendido. ¡Listo para conducir!");
        }
    }
}

