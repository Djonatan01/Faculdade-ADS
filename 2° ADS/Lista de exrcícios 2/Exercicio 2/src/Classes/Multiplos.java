package Classes;
import java.util.Scanner;
public class Multiplos {

	private String conjunto;
	private int i;
	private Scanner x;
	
	public Multiplos() 
	{
		conjunto = "";
		x = new Scanner(System.in);
	// TODO Auto-generated constructor stub
	}
	public void LerDados()
	{
		System.out.println("Informe o conjunto de numeros?");
		conjunto = x.next();
	}
	public void processamento()
	{
        String number = String.valueOf(conjunto);

        char[] digits1 = number.toCharArray();

        for(i = 1; i < digits1.length; i++) {
            //System.out.println(digits1[i]);
            
            if (i % 3 == 0 )
            {
            	System.out.println("O numero " + i + " é multiplo de 3");
            }
            if (i % 5 == 0 )
            {
            	System.out.println("O numero " + i + " é multiplo de 5");
            }
        }
	}
}
