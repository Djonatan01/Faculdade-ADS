package Main;

/*  1 - Faça um programa que leia um intervalo de números inteiros, imprima todos os pares e o
somatório destes números
*/

import Classes.IntervaloNumeros;

public class Main 
{

	/**
	 * @param args
	 */
	public static void main(String[] args) 
	{
		IntervaloNumeros obj = new IntervaloNumeros();
		
		obj.LerDados();
		obj.processamento();
		obj.imprimir();

	}

}
