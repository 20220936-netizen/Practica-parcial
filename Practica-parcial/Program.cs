using System;
using System.Collections.Generic; // Se importa para poder usar List<T>

namespace ProyectoPOO
{
    // Clase principal donde inicia la ejecución del programa
    class Program
    {
        // Método Main: punto de entrada del programa
        static void Main(string[] args)
        {
            // ======================================================
            // 1. SINTAXIS BÁSICA Y VARIABLES
            // ======================================================

            // Se muestra un mensaje de bienvenida en pantalla
            Console.WriteLine("Bienvenidos a mi proyecto de practica parcial.");

            // Declaración de variables de distintos tipos de datos
            int edad = 27;              // Tipo entero
            string nombre = "Aiker";   // Tipo cadena de texto
            double promedio = 89.5;     // Tipo decimal con punto flotante
            bool esActivo = true;       // Tipo booleano (true/false)

            // Se imprimen las variables en pantalla
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"¿Está activo?: {esActivo}");

            // ======================================================
            // 2. ESTRUCTURAS DE CONTROL
            // ======================================================

            // Se solicita al usuario que digite un número
            Console.Write("\nDigite un número: ");
            int numero = int.Parse(Console.ReadLine()); 
            // int.Parse convierte el texto ingresado a número entero

            // Estructura condicional para verificar si es par o impar
            if (numero % 2 == 0)
                Console.WriteLine("El número es PAR");
            else
                Console.WriteLine("El número es IMPAR");

            // Bucle for que imprime los números del 1 al 10
            Console.WriteLine("\nNúmeros del 1 al 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // ======================================================
            // 3. CLASES Y OBJETOS
            // ======================================================

            // Creación de objetos (instancias) de la clase Persona
            Persona p1 = new Persona("Juan", 22);
            Persona p2 = new Persona("Maria", 21);
            Persona p3 = new Persona("Pedro", 23);

            // Se llama al método Presentarse() de cada objeto
            p1.Presentarse();
            p2.Presentarse();
            p3.Presentarse();

            // ======================================================
            // 4 y 5. HERENCIA Y POLIMORFISMO
            // ======================================================

            // Se crean objetos de las clases hijas
            Perro perro = new Perro();
            Gato gato = new Gato();

            // Se llama el método sobrescrito en cada clase
            perro.HacerSonido();
            gato.HacerSonido();

            // Se demuestra polimorfismo usando una lista del tipo base Animal
            Console.WriteLine("\nPolimorfismo con lista:");

            List<Animal> animales = new List<Animal>();
            animales.Add(perro); // Se agrega un objeto Perro
            animales.Add(gato);  // Se agrega un objeto Gato

            // Aunque la lista es de tipo Animal,
            // cada objeto ejecuta su propia versión del método
            foreach (Animal animal in animales)
            {
                animal.HacerSonido();
            }

            // ======================================================
            // 6. ENCAPSULAMIENTO
            // ======================================================

            // Se crea una cuenta bancaria
            CuentaBancaria cuenta = new CuentaBancaria();

            // Se deposita dinero
            cuenta.Depositar(1000);

            // Se obtiene el saldo usando el método público
            Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo()}");

            // ======================================================
            // 7. INTERFACES Y ABSTRACCIÓN
            // ======================================================

            // Se crean objetos usando la interfaz IVehiculo
            IVehiculo carro = new Carro();
            IVehiculo moto = new Motocicleta();

            // Se ejecutan los métodos implementados
            carro.Encender();
            carro.Apagar();

            moto.Encender();
            moto.Apagar();

            Console.WriteLine("\nFin del programa...");
        }
    }
}
