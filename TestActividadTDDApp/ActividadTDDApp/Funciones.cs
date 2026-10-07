using System;

namespace ActividadTDDApp
{
    public class Funciones
    {
        public long CalcularFactorial(int n)
        {
            if (n < 0) return -1;
            if (n == 0 || n == 1) return 1;

            return n * CalcularFactorial(n - 1);
        }
    }
}