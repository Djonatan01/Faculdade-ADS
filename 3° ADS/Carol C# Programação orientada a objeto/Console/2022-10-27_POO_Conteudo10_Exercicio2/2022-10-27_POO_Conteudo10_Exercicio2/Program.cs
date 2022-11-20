

namespace _2022_10_27_POO_Conteudo10_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioBruto, imposto, porcentReajuste;
            bool verific = true;

            while (verific)
            {
                try
                {

                    Console.WriteLine("Informar nome do Funcionário: \n");
                    nome = Console.ReadLine();
                    if (nome == "")
                    {
                        Console.WriteLine("Nome não pode estar em branco\n");
                    }
                    else
                    {
                        while (verific)
                        {
                            try
                            {
                                Console.WriteLine("\nInformar o salário bruto do funcionário");
                                salarioBruto = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                                if (salarioBruto < 0)
                                {
                                    Console.WriteLine("\nSalario não pode ser negativo");

                                }
                                else
                                {
                                    while (verific)
                                    {
                                        try
                                        {
                                            Console.WriteLine("\nInformar o imposto");
                                            imposto = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                                            if (imposto < 0)
                                            {
                                                Console.WriteLine("\nImposto não pode ser negativo");
                                            }
                                            else
                                            {
                                                Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);
                                                Console.WriteLine("\nFuncionário: {0}, ${1}", funcionario.Nome, funcionario.SalarioLiquido());

                                                while (verific)
                                                {
                                                    try
                                                    {
                                                        Console.WriteLine("\nDigite a porcentagem para aumentar o salario:");
                                                        porcentReajuste = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                                                        if (porcentReajuste < 0)
                                                        {
                                                            Console.WriteLine("\nValor da porcentagem não pode ser negativo");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("\nDados Atualizados: {0}, ${1}", funcionario.Nome, funcionario.AumentarSalario(porcentReajuste));
                                                            verific = false;
                                                        }



                                                    }
                                                    catch (FormatException)
                                                    {
                                                        Console.WriteLine("\nDigite apenas números");
                                                    }

                                                }

                                               
                                            }

                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("\nDigite apenas números");
                                        }
                                    }
                                }


                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nDigite apenas números");
                            }
                        }

                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Nome em branco");
                }
            }
        }
    }
}