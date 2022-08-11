package Classes;

import java.util.Scanner;

public class Impares 
{
	private int i,im, vet[];
	private Scanner x;
	public Impares() 
	{
		x = new Scanner(System.in);
		vet = new int [30];
		im =0;
		// TODO Auto-generated constructor stub
	}
	public void LerDados()
	{
		for (i = 0; i < 30;i++)
		{
			System.out.println("Informe um numero ");
			vet[i] =x.nextInt();
		}
	}
	public void processamento ()
	{
		for (i = 0; i < 30;i++)
		{
			if (vet[i] % 2 != 0) im = im + 1;
		}		
	}
	
	public void imprimir()
	{
		System.out.println("O total de numeros impares foi " + im);
	}

}
