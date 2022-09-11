using System.IO;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 0;
        int b = 0;

        //1 - Analise os algoritmos (representados em Diagrama de Chapin) abaixo e diga o que será 
        //impresso na tela ao serem executados:
        //A)
        Console.WriteLine("Exercício (A)");
        a = 10;
        b = 20;

        Console.WriteLine( $"B = {b}");

        b = 5;

        Console.WriteLine($"A = {a}");
        Console.WriteLine($"B = {b}");

        //B)
        Console.WriteLine();
        Console.WriteLine("Exercício (B)");
        int c = 0;
        a = 30;
        b = 20;

        c = a + b;

        Console.WriteLine($"Valor de C = {c}");

        b = 10;

        Console.WriteLine($"Valor de B = {b} e valor de C {c}");

        c = a + b;

        Console.WriteLine($"Valor de A = {a} o valor de B = {b} e valor de C {c}");

        //C)
        Console.WriteLine();
        Console.WriteLine("Exercício (C)");
        a = 10;
        b = 20;
        c = a;
        b = c;
        a = b;

        Console.WriteLine($"Valor de A = {a} o valor de B = {b} e valor de C {c}");

        //D)
        Console.WriteLine();
        Console.WriteLine("Exercício (D)");
        a = 10;
        b = a + 1;
        a = b + 1;
        b = a + 1;

        Console.WriteLine($"Valor de A = {a}");
        a = b + 1;
        Console.WriteLine($"Valor de A = {a} o valor de B = {b}");

        //E)
        Console.WriteLine();
        Console.WriteLine("Exercício (E)");
        a = 10;
        b = 5;
        c = a + b;
        b = 20;

        Console.WriteLine($"Valor de A = {a} o valor de B = {b} e valor de C {c}");

        //F)
        int x = 0;
        int y = 0;
        int z = 0;

        Console.WriteLine();
        Console.WriteLine("Exercício (F)");

        x = 1;
        y = 2;
        z = y - x;

        Console.WriteLine($"Valor de Z {z}");
        x = 5;
        y = x + z;

        Console.WriteLine($"Valor de X = {x} o valor de Y = {y} e valor de Z {z}");

        //2 – Elabore um algoritmo que calcule a média da idade de 5 alunos.
        Console.WriteLine("\nExercício (2)");
        Console.WriteLine("Montar um programa que calcule a média da idade de 5 alunos e exiba o nome de cada aluno com sua idade e a média da idade dos alunos.");

        int med = 0;
        int idade = 0;
        int i = 0;
        x = 0;
        string[] vetNomeAluno = new string[6];
        double Nota =0;
        double[] vetMedAluno = new double[6];
        string[] vetIdade = new string[6];

        for (i = 1; i < 6; i++)
        {
            Console.WriteLine($"Digite o nome do aluno {i}");
            vetNomeAluno[i] = Console.ReadLine();
            Console.WriteLine($"Digite a idade de {vetNomeAluno[i]}");
            vetIdade[i] = Console.ReadLine();

            for (x = 1; x < 6; x++)
            {
                Console.WriteLine($"Digite a nota {x} do aluno {vetNomeAluno[i]}");
                Nota = Nota + float.Parse(Console.ReadLine());
            }
            vetMedAluno[i] = Nota / 5;
            Nota = 0;
        }
        for (i = 1; i < 6; i++)
        {
            Console.WriteLine("A média do Aluno {0} é = {1}", vetNomeAluno[i], vetMedAluno[i]);
            Console.WriteLine($"A idade do Aluno {vetNomeAluno[i]} é = {vetIdade[i]}");
        }

        //3 – Crie um algoritmo que verifique se um número informado é par ou ímpar.
        Console.WriteLine("Exercício 3");















    }
}