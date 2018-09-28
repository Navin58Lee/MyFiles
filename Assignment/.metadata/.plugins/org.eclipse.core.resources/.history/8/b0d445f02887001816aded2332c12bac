package bin;
import java.util.*;
public class Exceptions {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		//ArithmeticException
		System.out.println("Enter the values of a and  b");
		try
		{
		int a = in.nextInt();
		int b = in.nextInt();
		
			int c = a/b;
			System.out.println(a+"/"+b+" = "+c);
		}
		catch(ArithmeticException e)
		{
			System.out.println("Number cannot be divided by zero");
		}
		catch(InputMismatchException ime)
		{
			System.out.println("only numbers are allowed");
		}
		System.out.println();
		//NullPointerException
		try
		{
			String x = null;
			System.out.println(x.charAt(2));
		}
		catch(NullPointerException r)
		{
			System.out.println("String is empty");
		}
		System.out.println();
		//ArrayIndexOutOfBoundsException
		System.out.println("Enter the number of elements in the array");
		int n = in.nextInt();
		int arr [] = new int[n];
	    for(int i=0;i<n;i++)
	    {
	    	arr[i] = in.nextInt();
	    }
	    System.out.println("Printing the elements of the array");
	    try
	    {
	    for(int i=0;i<n;i++)
	    {
	    	System.out.print(arr[i]+" ");
	    }
	    }
	    catch(ArrayIndexOutOfBoundsException y)
	    {
	    	System.out.println(y.toString());
	    }
	    System.out.println();
	    //InputMismatchException
	    System.out.println("Enter your age");
	    try{
	    int age = in.nextInt();
	    	System.out.println("Age: "+age);
	    }
	    catch(InputMismatchException s)
	    {
	    	System.out.println("InputMismatchException");
	    }
	    System.out.println();
	    
	    try
	    {
	    	String s = "12";
	    	int z = Integer.parseInt(s);
	    	System.out.println(s);
	    }
	    catch(NumberFormatException g)
	    {
	    	System.out.println(g.toString());
	    	System.out.println();
	    }
	    finally
	    {
	    	System.out.println("Finally Block Executed");
	    }
	}
}
