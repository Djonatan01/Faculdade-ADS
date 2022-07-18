package Classes;


import java.util.Scanner;

public class IntervaloNumeros 
{
	private int n1, n2, i, impar, par;
	private int n3, n4;
	private Scanner x;
	
	public IntervaloNumeros() 
	{
		n1 = n2 = i = impar = par = 0;
		x = new Scanner(System.in);
		// TODO Auto-generated constructor stub
	}
	
	public void LerDados()
	{
		System.out.println("Informe o valor inicial do intervalo");
		n1 = x.nextInt();
		System.out.println("Informe o valor final do intervalo");
		n2 = x.nextInt();
	}
	
	public void processamento()
	{
		for ( i = n1; i <= n2; i++)
		{
			if (i % 2 == 0)
			{
				par = par + i;
				n4 = n4 + 1;
			}else
			{
				impar = impar + i;
				n3 = n3 + 1;
			}
		}
	}
	public void imprimir()
	{
		System.out.println("No intelavo de " + n1 + " a " + n2);
		System.out.println("Existem " + n4 + " pares e " + n3 + " impares");
		System.out.println("A soma de todos os numeros pares do intervalo foi " + par);
		System.out.println("A soma de todos os numeros impares do intevalo foi " + impar);
	}

}
