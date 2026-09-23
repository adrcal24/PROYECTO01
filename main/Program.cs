// Program.cs
using main;
using System;

namespace EjemploPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar el objeto
            Persona persona1 = new Persona("Laura", 25);

            Console.WriteLine("Estado inicial:");
            persona1.MostrarDatos();

            // --- Subtarea 2: Llamar al setter desde Main ---
            persona1.Edad = 26; // Asigna el valor llamando al 'set' internamente

            Console.WriteLine("\nEstado tras la modificación:");
            Console.WriteLine($"Nueva edad (usando get): {persona1.Edad}");
            persona1.MostrarDatos();
        }
    }
}