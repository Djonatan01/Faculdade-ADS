internal class Program
{
    private static void Main(string[] args)
    {
        /* 1) Fazer um programa que leia o número de matrícula de um funcionário, quantidade de horas trabalhadas no 
        mês, o valor que recebe por hora e calcule o salário desse funcionário. A seguir, mostre o número de matrícula 
        e o salário total do funcionário (com duas casas decimais). {base para pensar em algo mais elaborado, que 
        pode ser desenhado como parte de um sistema para implantar para uma pequena empresa gerar relatórios 
        mensais para o contador}*/

        Console.WriteLine("Informe sua matricula na empresa");
        double Mat =  Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe quanto recebe por hora");
        float vHora =  float.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de horas trabalhadas");
        float tHoras =  float.Parse(Console.ReadLine());

        float salario = vHora * tHoras;

        var texto = DateTime.Today.ToString("MMMM");
        var mes = texto.Length > 1 ? char.ToUpper(texto[0]) + texto.Substring(1) : texto.ToUpper();
       
        Console.WriteLine("O Funcionário com ID {0} vai receber o salario R$ {1:F2} no mês de {2}",Mat,salario,mes);
    }
}