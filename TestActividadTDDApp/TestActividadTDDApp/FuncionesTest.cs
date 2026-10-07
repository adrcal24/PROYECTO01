using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public class FuncionesTest
    {
        private readonly Funciones _funciones = new Funciones();

        [TestMethod]
        public void CalcularFactorial_NumeroNegativo_DevuelveMenosUno()
        {
            Assert.AreEqual(-1, _funciones.CalcularFactorial(-5));
        }

        [TestMethod]
        public void CalcularFactorial_Cero_DevuelveUno()
        {
            Assert.AreEqual(1, _funciones.CalcularFactorial(0));
        }

        [TestMethod]
        public void CalcularFactorial_NumeroPositivo_DevuelveFactorialCorrecto()
        {
            Assert.AreEqual(120, _funciones.CalcularFactorial(5));
        }

        [TestMethod]
        [DataRow("", false)]
        [DataRow(null, false)]
        [DataRow("abc#123", false)]
        [DataRow("contraseñavalida1", false)]
        [DataRow("contraseña#123", true)]
        public void EsContrasenyaValida_VariosCasos(string contrasenya, bool esperado)
        {
            bool resultado = _funciones.EsContrasenyaValida(contrasenya);
            Assert.AreEqual(esperado, resultado);
        }
    }
}