using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Conteudo10_exercicios
{
    internal class Retangulo
    {
        private Double resultado, altura, largura;

        public Retangulo(double _altura, double _largura)
        {
            this.resultado = 0;
            this.altura = _altura;
            this.largura = _largura;
        }
        public double getArea()
        {
            this.resultado = this.largura * this.altura;
            return this.resultado;
        }
        public double getPerimetro()
        {
            resultado = 2 * (this.largura + this.altura);
            return this.resultado;
        }
        public double getDiagonal()
        {
            resultado = Math.Sqrt(Math.Pow(this.largura, 2) + Math.Pow(this.altura, 2));
            return this.resultado;
        }
    }
}
