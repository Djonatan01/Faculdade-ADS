internal class Programa
{
    public static string horas;
    private static void Main(string[] args)
    {
        
        //Console.WriteLine("2 ) Fazer um programa que utilize leia o nome e sobrenome de um usuário, " +
        //    "qual a orientação sexual (para utilizar Sra. Ou Sr. na saudação), um horário digitado pelo " +
        //    "mesmo, e imprima:\v“Bom dia <Sra. ou Sr.> <1º nome> + <2º nome>!”, \r\n“Boa tarde <1º nome>!”, " +
        //    "ou \r\n“Boa noite <Sra. ou Sr.> <2º nome>!”, de acordo com o horário. \r\nDetalhes: Escrever as " +
        //    "ações para o usuário, sugestão usar “IF”;\r\nEx: Entrou nome: Steve Jobs\r\nEntrou hora: 10\r\nImprime " +
        //    "na tela: Bom dia Sr. Steve Jobs\r\n");

        Console.WriteLine("Informe seu nome e sobrenome:");
        String nomex = Console.ReadLine();
        
        Console.WriteLine("Informe seu sexo");
        String sexo = Console.ReadLine().ToUpper();
        Boolean teste = true;
   
        int h;
        
        String[] nomes = nomex.Split(' ');
        String nome = nomes[0];
        String sobrenome = nomes[1];
        String horario;

        h = int.Parse(DateTime.Now.ToString("HH"));
        String horas = DateTime.Now.ToString("HH:mm:ss");
        Console.WriteLine(h);
        if (h >= 18)
        {
            horario = "Boa noite";
            
        }else if (h >= 12)
        {
            horario = "Boa tarde";
        }
        else
        {
             horario = "Bom dia";
        }

        if (sexo == "MASCULINO")
        {
            Console.WriteLine($"{horario} Sr.{nome} {sobrenome} são exatamente {horas} horas");
        }
        else
        {
            Console.WriteLine($"{horario} Sra.{nome} {sobrenome} são exatamente {horas} horas");
        }
        
    }
}