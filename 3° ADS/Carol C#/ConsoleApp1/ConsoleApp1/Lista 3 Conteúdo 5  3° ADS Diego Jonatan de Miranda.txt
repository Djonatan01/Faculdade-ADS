using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static DateTime data_nasc;

    private static void Main(string[] args)
    {
        int a = 0;
        int b = 0;

        //1 - Analise os algoritmos (representados em Diagrama de Chapin) abaixo e diga o que será 
        //impresso na tela ao serem executados:
        //A)
        Console.WriteLine("1 -Elaborar um programa para cada algoritmo " +
            "(representados em Diagrama de Chapin) do item 1");
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
        Console.WriteLine("Montar um programa que calcule a média da idade de 5 alunos e " +
            "exiba o nome de cada aluno com sua idade e a média da idade dos alunos.");

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
        Console.WriteLine("\nExercício 3");
        Console.WriteLine("\nCrie um algoritmo que verifique se um número informado é par ou ímpar.");

        Console.WriteLine("Digite um numero inteiro");
        x = int.Parse(Console.ReadLine());
        int par = 0;

        par = x % 2;
        if (par == 0)
        {
            Console.WriteLine($" O numero {x} é par");
        }
        else
        {
            Console.WriteLine($" O numero {x} é impar");
        }

        //4 – Escreva um programa para ler as dimensões de um
        //retângulo(base e altura), calcular e escrever a área
        //do retângulo. (ar = b * a)
        Console.WriteLine("\nExercício 4");
        Console.WriteLine("Escreva um programa para ler as dimensões " +
            "de um retângulo (base e altura), calcular e escrever a área do " +
            "retângulo. (ar = b*a )\n");

        Console.WriteLine("Informe a altura do retângulo");
        float al = float.Parse(Console.ReadLine());
        Console.WriteLine("Informa a base do retângulo");
        float bs = float.Parse(Console.ReadLine());

        float ar = al * bs;

        Console.WriteLine($"A área do retângulo informado é {ar}");

        /*
         * 5 – Faça um programa que leia a idade de uma pessoa expressa em anos, 
         * meses e dias e escreva a idade dessa pessoa expressa apenas em dias. 
         * Considerar ano com 365 dias e mês com 30 dias.
         */
        Console.WriteLine("\nExercício 5");
        Console.WriteLine("Faça um programa que leia a idade de uma pessoa " +
            "expressa em anos, meses e dias e escreva a idade dessa pessoa " +
            "expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.\n");

        DateTime data = DateTime.Today;
        Console.WriteLine("Diegite a data do seu nascimento ex: 00/00/0000");
        data_nasc = Convert.ToDateTime(Console.ReadLine());

        TimeSpan id_atual = data - data_nasc;
        string[] split = Convert.ToString(id_atual).Split('.');


        int ano_nasc = int.Parse(data_nasc.ToString("yyyy"));
        int ano_atual = int.Parse(data.ToString("yyyy"));

        idade = ano_atual - ano_nasc;

        Console.WriteLine($"Você tem anos {idade} de idade e {split[0]} dias de vida");


        /*
         * 6 – Faça um programa que exiba quantas pessoas possuem mais de 18 anos. 
         * O algoritmo deverá ler a idade de 10 pessoas.
         */
        Console.WriteLine("\nExercício 6");
        Console.WriteLine("Faça um programa que exiba quantas pessoas possuem mais " +
            "de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.");
        x = 0;
        y = 0;

        for (i = 0;i <10;i++ )
        {
            Console.WriteLine($"Informe a idade da {i+1}° pessoa");
            idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                x++;
            }
            else
            {
                y++;
            }
        }
        Console.WriteLine($"O total de pessoas maior que 18 anos é = {x}");
        Console.WriteLine($"O totla de pessoas menor que 18 anos é = {y}");
    }
}