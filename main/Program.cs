using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Instanciamos la clase Persona con un nombre y una edad
            Persona miPersona = new Persona("Carlos", 20);

            // 2. Llamamos al método que hemos creado para comprobar si es mayor de edad
            miPersona.EsMayorDeEdad();
        }
    }
}