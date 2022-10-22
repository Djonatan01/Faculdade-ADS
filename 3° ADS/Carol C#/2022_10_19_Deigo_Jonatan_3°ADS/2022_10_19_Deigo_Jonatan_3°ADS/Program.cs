internal class Program
{

    /*
     * Criar um algoritmo que realize o cálculo de venda de um mercado, o sistema deve conter o menu com as opções a serem vendidas.
     * Sistema foi baseado nos exercícios 2 do conteúdo 7 e no exercício 2 do conteúdo 6.
     */

    private static void Main(string[] args)
    {
        // Criação do vetor com os itens a ser vendido e o preço por padrão
        string[] vetItem = new string[17];
        double[] vetPreco = new double[17];
        double totalCompra = 0;
        int quantComprada = 0
            ;
        vetItem[0] = "Arroz";
        vetItem[1] = "Feijão";
        vetItem[2] = "Óleo de soja";
        vetItem[3] = "Sal";
        vetItem[4] = "Açúcar";
        vetItem[5] = "Café";
        vetItem[6] = "Molho de tomate";
        vetItem[7] = "Macarrão";
        vetItem[8] = "Milho";
        vetItem[9] = "Farinha de trigo";
        vetItem[10] = "Farinha de mandioca";
        vetItem[11] = "Leite";
        vetItem[12] = "Manteiga";
        vetItem[13] = "Chá";
        vetItem[14] = "Carnes";
        vetItem[15] = "Peixes";
        vetItem[16] = "Ovos.";

        vetPreco[0] = 15.00;
        vetPreco[1] = 8.00;
        vetPreco[2] = 11.00;
        vetPreco[3] = 12.00;
        vetPreco[4] = 13.00;
        vetPreco[5] = 1.00;
        vetPreco[6] = 13.00;
        vetPreco[7] = 15.00;
        vetPreco[8] = 12.00;
        vetPreco[9] = 9.00;
        vetPreco[10] = 11.00;
        vetPreco[11] = 10.00;
        vetPreco[12] = 16.00;
        vetPreco[13] = 17.00;
        vetPreco[14] = 6.00;
        vetPreco[15] = 18.00;
        vetPreco[16] = 1.00;

        Console.WriteLine("Selecione os itens desejados");

        do
        {
            Console.WriteLine("Escolha uma opção?\n"+
                "        A	-	Arroz	 R$ 15,00 	\n	"+
                "B	-	Feijão	 R$ 8,00 	\n	"+
                "C	-	Óleo de soja	 R$ 11,00 	\n	"+
                "D	-	Sal	 R$ 12,00 	\n	"+
                "E	-	Açúcar	 R$ 13,00 	\n	" +
                "F	-	Café	 R$ 1,00 	\n	" +
                "G	-	Molho de tomate	 R$ 13,00 	\n	"
                );

            string op = Console.ReadLine().ToUpper();
            switch (op)
            {
                case "A":
                    Console.WriteLine("O item selecionado foi Arroz");
                    Console.WriteLine("Informe a quantidade desejada");
                    quantComprada = int.Parse(Console.ReadLine());

                    totalCompra = totalCompra + (quantComprada * vetPreco[0]);

                    break;
                case "B":
                    Console.WriteLine("O item selecionado foi feijão");
                    Console.WriteLine("Informe a quantidade desejada");
                    quantComprada = int.Parse(Console.ReadLine());

                    totalCompra = totalCompra + (quantComprada * vetPreco[1]);

                    break;

                case "C":
                    Console.WriteLine("O item selecionado foi Óleo de soja");
                    Console.WriteLine("Informe a quantidade desejada");
                    quantComprada = int.Parse(Console.ReadLine());

                    totalCompra = totalCompra + (quantComprada * vetPreco[2]);

                    break;
                case "D":
                    Console.WriteLine("O item selecionado foi Sal");
                    Console.WriteLine("Informe a quantidade desejada");
                    quantComprada = int.Parse(Console.ReadLine());

                    totalCompra = totalCompra + (quantComprada * vetPreco[3]);
                    break;
                case "E":
                    Console.WriteLine("O item selecionado foi açucar");
                    Console.WriteLine("Informe a quantidade desejada");
                    quantComprada = int.Parse(Console.ReadLine());

                    totalCompra = totalCompra + (quantComprada * vetPreco[4]);
                    break;
                case "F":
                    Console.WriteLine("O item selecionado foi café");
                    Console.WriteLine("Informe a quantidade desejada");
                    quantComprada = int.Parse(Console.ReadLine());

                    totalCompra = totalCompra + (quantComprada * vetPreco[5]);
                    break;
                case "G":
                    Console.WriteLine("O item selecionado foi Molho de tomate");
                    Console.WriteLine("Informe a quantidade desejada");
                    quantComprada = int.Parse(Console.ReadLine());

                    totalCompra = totalCompra + (quantComprada * vetPreco[6]);
                    break;
                case "X":
                    break;
            }
            if (op == "X")
            {
                break;
            }
            else
            {
                Console.WriteLine("\nDeseja escolher outro produto?\n" +
                    "S para sim\n" +
                    "N para não\n");
                var desejado = Console.ReadLine().ToUpper();
                if (desejado == "N") break;
            }
        } while (true);

        Console.WriteLine("O total da compra foi R$ {0:F2}", totalCompra);
    }
}