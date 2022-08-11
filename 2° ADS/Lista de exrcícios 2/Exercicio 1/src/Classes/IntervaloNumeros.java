package Classes;

import java.util.Scanner;

public class IntervaloNumeros 
{
	private int n1, n2, i, impar, par;
	public IntervaloNumeros(int n1, int n2, int i, int impar, int par) {
		this.n1 = n1;
		this.n2 = n2;
		this.i = i;
		this.impar = impar;
		this.par = par;
	}

	public int getN1() {
		return n1;
	}

	public void setN1(int n1) {
		this.n1 = n1;
	}

	public int getN2() {
		return n2;
	}

	public void setN2(int n2) {
		this.n2 = n2;
	}

	public int getI() {
		return i;
	}

	public void setI(int i) {
		this.i = i;
	}

	public int getImpar() {
		return impar;
	}

	public void setImpar(int impar) {
		this.impar = impar;
	}

	public int getPar() {
		return par;
	}

	public void setPar(int par) {
		this.par = par;
	}
	private int n3, n4;
	private Scanner x;
	
	/**
	 * 
	 */
	public IntervaloNumeros() 
	{
		n1 = 0; 
		n2 = 0;
		i = 0;
		impar = 0;
		par = 0;
		extracted();
	}

	private void extracted() {
		x = new Scanner(System.in);
	}
	
	/**
	 * 
	 */
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
