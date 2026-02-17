using System;

namespace ProyectoPOO
{
    // Clase Carro implementa la interfaz IVehiculo
    public class Carro : IVehiculo
    {
        // Implementación del método Encender
        public void Encender()
        {
            Console.WriteLine("El carro está encendiendo");
        }

        // Implementación del método Apagar
        public void Apagar()
        {
            Console.WriteLine("El carro se ha apagado.");
        }
    }
}
