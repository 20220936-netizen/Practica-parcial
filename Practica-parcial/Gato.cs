using System;

namespace ProyectoPOO
{
    // Clase Gato hereda de Animal
    public class Gato : Animal
    {
        // Se sobrescribe el método HacerSonido
        public override void HacerSonido()
        {
            Console.WriteLine("Miau");
        }
    }
}
