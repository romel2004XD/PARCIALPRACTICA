using System;

namespace Parcial1Programacion1G2
{
    public class Moto : Vehiculo
    {
        public int Cilindraje { get; set; }

        public Moto(string marca, string modelo, int anio, int cilindraje) 
            : base(marca, modelo, anio)
        {
            Cilindraje = cilindraje;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Cilindraje: {Cilindraje} cc");
        }

        public override void Encender()
        {
            Console.WriteLine("La moto está encendida. ¡ya podes!");
        }
    }
}