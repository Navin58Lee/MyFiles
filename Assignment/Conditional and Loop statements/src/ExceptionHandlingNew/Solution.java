package ExceptionHandlingNew;
import java.util.*;
public class Solution {
	Scanner in = new Scanner(System.in);
	public String division()
	{
		System.out.println("Enter the values of a and b");
	    try
	    {
	    	int a = in.nextInt();
	    	int b = in.nextInt();
	    	int c = a/b;
	    	System.out.println(c);
	    }
	    catch(ArithmeticException ae)
	    {
	    	System.out.println("Number cannot be divided by zero");
	    }
	    catch(InputMismatchException ime)
	    {
	    	return ("number is not valid");
	    }
	    return ("0");
	 
	}
	public void array()
	{
		try
		{
			System.out.println("Enter the number of elements");
			int n = in.nextInt();
			int arr [] = new int[n];
			System.out.println("Enter the elements");
			for(int i=0;i<n;i++)
			{
				arr[i]  =in.nextInt();
			}
			System.out.println("Enter any index");
			int i = in.nextInt();
			System.out.println("The number in the index you have entered is: "+arr[i]);
		}
		catch(InputMismatchException ey)
		{
			System.out.println("Enter a valid number");
		}
		catch(ArrayIndexOutOfBoundsException a)
		{
			System.out.println("Enter a valid index");
		}
		finally{
//			
		}
		
	}
	
	
	public void inputMismatch()
	{
		System.out.println("Enter your age");
	    try
	    {
	    	int age = in.nextInt();
	    	
	    	System.out.println("Your age is: "+age);
	    	
	    }
	    catch(InputMismatchException ie)
	    {
	    	System.out.println("Age can contain only numbers");
	    }
	    
	    finally{
//	    	
	    System.out.println();
	    }
	}
	
	
	public void numberFormat()
	{
		try
		{
	    System.out.println("Enter any number");
		String x = in.next();
		int y = Integer.parseInt(x);
		System.out.println(x);
		}
		catch(NumberFormatException nfe)
		{
			System.out.println("String cannot be converted into an integer");
		}
		System.out.println();
	}
//	

}
