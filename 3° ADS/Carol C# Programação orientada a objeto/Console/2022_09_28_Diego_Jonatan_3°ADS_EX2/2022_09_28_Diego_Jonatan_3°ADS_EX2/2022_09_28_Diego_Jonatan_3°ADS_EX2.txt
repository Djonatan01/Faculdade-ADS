using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        /*2) Fazer um programa que leia três valores com ponto flutuante de dupla 
         * precisão: A, B e C. Em seguida,oferecer um pequeno menu onde o usuário 
         * escolha o que deseja calcular (pode ter como base o código de exemplo 
         * Do...While e Switch..Case), após escolher, faça o cálculo e mostre o 
         * resultado e permita a pessoa escolher se encerrará o programa ou escolherá 
         * nova opção:
         * 
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B */

        Console.WriteLine("Selecione uma opção do menu para calculo de área");

        do
        {
            Console.WriteLine("Escolha uma opção?\n\n" +
                "A - Calcular a área de um triângulo retângulo\n" +
                "B - Calcular a área do círculo\n" +
                "C - Calcular a área do trapézio\n"+
                "D - Calcular a área do quadrado\n"+
                "E - Calcular a área do retângulo\n"+
                "F - Se desejar sair"
                );

            var op = Console.ReadLine().ToUpper();

            Console.WriteLine("A opção selecionada foi '{0}'", op);
            switch (op)
            {
                case "A":
                    Console.WriteLine("Informe a base do triângulo retângulo em centímetros");
                    double b = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Informe a altura do triângulo retângulo em centímetros");
                    double h = double.Parse(Console.ReadLine());
                    double triangulo = b * h / 2.0;

                    Console.WriteLine("A área do triângulo retângulo é {0:F2} cm2", triangulo);
                    break;
                case "B":
                    Console.WriteLine("Informe o raio do circulo em centímetros");
                    double r = double.Parse(Console.ReadLine());
                    double circulo = 3.14159 * (r * r);

                    Console.WriteLine("A área do circulo do raio informado é {0:F2} cm2", circulo);
                    break;

                case "C":
                    Console.WriteLine("Informe o comprimento da base maior do trapézio em centímetros");
                    double bm = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Informe o comprimento da base menor do trapézio em centímetros");
                    double bn = double.Parse(Console.ReadLine());
       
                    Console.WriteLine("Informe a altura do trapézio em centímetros");
                    h = double.Parse(Console.ReadLine());
                    
                    double trapezio = ((bn + bm) * h) / 2;
                    Console.WriteLine("A área do trapézio informado é {0:F2} cm2", trapezio);
                    break;
                case "D":
                    Console.WriteLine("Informe o comprimento do quadrado em centímetros");
                    double c = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe a largura do quadrado em centímetros");
                    double l = double.Parse(Console.ReadLine());

                    double quadrado = c * l;

                    Console.WriteLine("A área do quadrado informado é {0:F2} cm2", quadrado);
                    break;
                case "E":
                    Console.WriteLine("Informe o comprimento do quadrado em centímetros");
                     c = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe a largura do quadrado em centímetros");
                     l = double.Parse(Console.ReadLine());

                    double retangulo = c * l;

                    Console.WriteLine("A área do retângulo informado é {0:F2} cm2", retangulo);
                    break;
                case "F":
                    break;
            }
            if (op == "F")
            {
                break;
            }
            else
            {
                Console.WriteLine("\nDeseja continuar?\n" +
                    "S para sim\n" +
                    "N para não\n");
                var desejado = Console.ReadLine().ToUpper();
                if (desejado == "N") break;
            }
        } while (true);
    }
}