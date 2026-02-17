using System;

namespace ProyectoPOO
{
    // Clase Persona representa a un individuo con nombre y edad
    public class Persona
    {
        // Propiedad pública Nombre
        // get permite obtener el valor
        // set permite modificar el valor
        public string Nombre { get; set; }

        // Propiedad pública Edad
        public int Edad { get; set; }

        // Constructor:
        // Se ejecuta cuando se crea un objeto de la clase
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método que muestra un mensaje de presentación
        public void Presentarse()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }
}
