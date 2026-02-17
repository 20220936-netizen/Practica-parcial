using System;

namespace ProyectoPOO
{
    // Clase base Animal
    // Sirve como clase padre para otras clases
    public class Animal
    {
        // Método virtual:
        // Permite que las clases hijas lo sobrescriban
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }
}
