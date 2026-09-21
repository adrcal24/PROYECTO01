using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    internal class Persona
    {
        public string Nombre;
        public int Edad;

        // Constructor
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método para mostrar datos
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }
}
