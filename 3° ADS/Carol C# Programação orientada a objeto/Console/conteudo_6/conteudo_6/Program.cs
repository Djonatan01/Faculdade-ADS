internal class Program
{
    private static void Main(string[] args)
    {
        double a = 0;
        double b = 0;
        double c = 0;
        double delta = 0;

        Console.WriteLine("1 ) Reescrever o programa que efetua o cálculo da fórmula de Bhaskhara " +
            "solicitando que o usuário insira os valores para a, b, c;  e exibindo uma mensagem de " +
            "retorno com os resultados finais.\r\n");

        Console.WriteLine("Informe o valor de A");
            a = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de B");
            b = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de C");
            c = int.Parse(Console.ReadLine());

        delta = Math.Pow(b, 2) - 4 * a * c;

        Console.WriteLine(delta);

        if(delta > 0)
        {
            double x1 = (-b + (Math.Sqrt(delta)) / (2 * a));

            double x2 = (-b - (Math.Sqrt(delta)) / (2 * a));

            Console.WriteLine("O valor de X1 é = {0:F2} O valor de X2 é = {1:F2}",x1,x2);
        }
        else
        {
            Console.WriteLine("O valor de Delta é menor ou = 0");
            Console.WriteLine("A fórmula de Bhaskhara não pode ser calculada");
        }

    }
}