using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //Variaveis
        bool presente = false;
        char genero = 'M';
        char letra = '\u0041';
        byte num1 = 126;
        int num2 = 1000;
        int num3 = 2147483647;
        long num4 = 2147483648L;
        float num5 = 2.5f;
        double num6 = 3.8;
        string nome = "Diego Jonatan de Miranda";
        Console.WriteLine("Minhas variáveis:");
        Console.WriteLine(nome);
        Console.WriteLine(presente);
        Console.WriteLine(genero);
        Console.WriteLine(letra);
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
        Console.WriteLine(num4);
        Console.WriteLine(num5);
        Console.WriteLine("\n",num6);

        //Concatenar texto mais variveis

        char generos = 'M';
        byte nume1 = 35;
        string nomes = "Diego Jonatan de Miranda";
        Console.WriteLine("{0} tem {1} anos e é do gênero {2}\n", nomes, nume1, generos);
        Console.WriteLine($"{nomes} tem {nume1} anos e é do gênero {generos} \n");
        Console.WriteLine(nomes + " tem " + nume1 + " anos e é do gênero " + generos + "\n");

        //Venda de produto
        //sistema de globalização

        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";
        byte idade = 35;
        int codigo = 301734;
        double preco1 = 2100.0;
        double preco2 = 650.50;
        double total = 0;
        double medida = 53.234567;
        Console.WriteLine("Produtos:\n");
        Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
        Console.WriteLine("{0}, cujo preco é $ {1:F2}\n", produto2, preco2);
        Console.WriteLine("O preço total da compra é R$ {0:F2} reais \n", (preco1 + preco2));
        Console.WriteLine("Registro: Diego Jonatan {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
        Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
        Console.WriteLine("Arredondado (duas casas decimais): {0:F2}", medida);
        Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F4",CultureInfo.InvariantCulture));
        Console.WriteLine();

        //Operacoes matematicas

        int a = 5;
        int b = 15;
        int c = 10;
        int d = 30;
        Console.WriteLine($"A soma de {a} mais {b} é = {a + b}");
        Console.WriteLine($"A subtração de {d} menos {c} é = {d - c}");
        Console.WriteLine($"A multiplicação de {c} x {a} é = {c * a}");
        Console.WriteLine(d / b);
        Console.WriteLine(c % a);

        //Operador aritimético atribuição e redução
        a++;
        Console.WriteLine(a);
        a += 10;
        Console.WriteLine(a);
        a -= 10;
        Console.WriteLine(a);
        a *= 10;
        Console.WriteLine(a);
        a /= 10;
        Console.WriteLine(a);
    }
}