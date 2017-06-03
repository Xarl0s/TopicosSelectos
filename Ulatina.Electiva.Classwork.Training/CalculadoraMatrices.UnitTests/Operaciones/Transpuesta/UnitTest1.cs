using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraMatrices.UnitTests.Operaciones.Transpuesta
{
    [TestClass]
    public class MatrizTranspuesta
    {
        WcfOperaciones.Dominio.Acciones.Transponer laAccion = new WcfOperaciones.Dominio.Acciones.Transponer();
        double[,] laMatrizDePrueba, elResultadoObtenido, elResultadoEsperado;

        [TestMethod]
        public void TransponerMatrizUnoPorUno()
        {
            // fijar el escenario de la prueba
            laMatrizDePrueba = new double[1, 1];
            laMatrizDePrueba[0, 0] = 35.93;
            elResultadoEsperado = new double[1, 1];
            elResultadoEsperado[0, 0] = 35.93;

            // invocar al método que se desea probar
            elResultadoObtenido = laAccion.Transpuesta(laMatrizDePrueba);

            // verificar el resultado obtenido
            Assert.AreEqual(elResultadoEsperado[0,0], elResultadoObtenido[0,0]);
        }

        [TestMethod]
        public void TransponerMatrizCuatroPorUno()
        {
        }

        [TestMethod]
        public void TransponerMatrizUnoPorCinco()
        {
        }

        [TestMethod]
        public void TransponerMatrizTresPorTres()
        {
        }

    }
}
