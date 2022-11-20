using _2022_10_27_POO_Conteudo10_Exercicio1;

namespace Exercicio1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            double largura, altura;
            Console.WriteLine("Entre com a largura do retangulo: ");
            largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com a altura do retangulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("A area do retangulo é: {0:F2}", retangulo.getArea(largura, altura));
            Console.WriteLine("O perímetro do retangulo é: {0:F2}", retangulo.getPerimetro(largura, altura));
            Console.WriteLine("A diagonal do retangulo é: {0:F2}", retangulo.getDiagonal(largura, altura));
        }
    }
}