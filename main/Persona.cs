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

        // Método Getter para obtener la edad
        public int getEdad()
        {
            return Edad;
        }

        // Método Setter para modificar la edad
        public int edad
        {
            get { return edad; }
            set
            {
                if (value >= 0)
                {
                    edad = value;
                }
                else
                {
                    Console.WriteLine("La edad no puede ser negativa.");
                }
            }
        }

        // Método para mostrar datos
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }
}
