// Program.cs
using main;
using System;

namespace EjemploPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Laura", 25);

            Console.WriteLine("Estado inicial:");
            persona1.MostrarDatos();

            persona1.Edad = 26;

            Console.WriteLine("\nEstado tras la modificación:");
            Console.WriteLine($"Nueva edad (usando get): {persona1.Edad}");
            persona1.MostrarDatos();
        }
    }
}