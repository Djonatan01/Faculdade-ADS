
public class Soma 
{
	public Soma ( int n1, int n2)
	{
		System.out.println("Soma dos inteiros " + (n1 + n2));
	}
	public Soma ( double n1, double n2)
	{
		System.out.println("Soma dos reais " + (n1 + n2));
	}
	public Soma()
	{
		System.out.println("teste");
	}
	public static void main(String[] args)
	{
		Soma obj1 = new Soma(10,20);
		Soma obj2 = new Soma(10.5,20.7);
		Soma obj3 = new Soma();
	}
}
