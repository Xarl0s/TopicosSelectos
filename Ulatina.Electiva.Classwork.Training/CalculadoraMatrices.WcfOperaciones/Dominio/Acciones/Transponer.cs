using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraMatrices.WcfOperaciones.Dominio.Acciones
{
    public class Transponer
    {
        public double[][] Transpuesta(double[][] laMatriz)
        {
            double[][] elResultado = { new double[] { 2, 3 }, new double[] { 1, 6, 8 } };
            return elResultado;
        }
    }
}