package bin;
class A
{
	static
	{
		System.out.println("Static block executed");
	}
	{
		System.out.println("Non static block executed");
	}
	public A()
	{
		System.out.println("Constructor executed");
	}
}

public class StaticAndNonStatic {
	public static void main(String [] args)
	{
		A obj = new A();
	}
}
