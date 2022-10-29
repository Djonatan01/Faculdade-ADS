using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Conteudo10_exercicios
{
    internal class Exe1
    {
        private Double resultado;

        public double getArea(double largura, double altura)
        {
            resultado = largura * altura;
            return resultado;

        }
        public double getPerimetro(double largura, double altura)
        {
            resultado = 2 * (largura + altura);
            return resultado;

        }

        public double getDiagonal(double largura, double altura)
        {
            resultado = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
            return resultado;

        }

    }
}
