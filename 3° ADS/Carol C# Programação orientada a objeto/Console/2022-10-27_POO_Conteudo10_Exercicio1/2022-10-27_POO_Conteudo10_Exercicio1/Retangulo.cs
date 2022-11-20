namespace _2022_10_27_POO_Conteudo10_Exercicio1
{
    
    internal class Retangulo
    {
        private double resultado;

        public Retangulo()
        {           
            resultado = 0;           
        }

        public double getArea(double largura, double altura)
        {
            resultado = largura * altura;
            return resultado;
            
        }

        public double getPerimetro(double largura, double altura)
        {
            resultado = 2*(largura + altura);
            return resultado;

        }

        public double getDiagonal(double largura, double altura)
        {
            resultado = Math.Sqrt(Math.Pow(largura,2) + Math.Pow(altura,2));
            return resultado;

        }


    }
}
