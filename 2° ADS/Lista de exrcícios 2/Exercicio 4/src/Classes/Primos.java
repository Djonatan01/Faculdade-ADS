package Classes;

import java.util.Scanner;

public class Primos 
{
	private int z, y, i, vet[];
	private Scanner x;
	
	public Primos()
	{
		i = y = z = 0;
		x = new Scanner(System.in);
		vet = new int [10];
	}
	public void LerDados()
	{
		for(i = 0; i <= 9 ;i++)
		{
			System.out.println("Informe um numero inteiro ");
			vet[i]= x.nextInt();
		}
	}
	public void processamento()
	{
		for (i = 0;i <=9;i ++)
		{
			for(y = 1; y <=10; y++)
			{
				if (vet[i] % y == 0)
				{
					z++;
				}
			}
			if (z == 2 ) 
			{
				System.out.println("O numero " + vet[i] + " é um numero primo");
			}else
			{
				System.out.println("O numero " + vet[i] + " não é um numero primo");
			}
			z=0;
		}
	}
}
