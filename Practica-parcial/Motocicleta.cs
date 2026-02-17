using System;

namespace ProyectoPOO
{
    // Clase Motocicleta implementa la interfaz IVehiculo
    public class Motocicleta : IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("La motocicleta ruge al encender");
        }

        public void Apagar()
        {
            Console.WriteLine("La motocicleta se ha apagado.");
        }
    }
}
