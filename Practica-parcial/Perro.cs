using System;

namespace ProyectoPOO
{
    // Clase Perro hereda de Animal
    public class Perro : Animal
    {
        // override indica que estamos sobrescribiendo
        // el método de la clase base
        public override void HacerSonido()
        {
            Console.WriteLine("Guau, guau");
        }
    }
}
