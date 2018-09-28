import java.util.*;
public class Example {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("Enter the values of a,b and c");
		int a = in.nextInt();
		int b = 5;
		int c = 10;
		if(b==c&a==c)
		{
			System.out.println("b is equal to c");
		}
		else
		{
			System.out.println("a is equal to c");
		}
		for(int i=1;i<=a;i++)
		{
			if(i%2==0&&i%3==0)
			{
				System.out.println(i+" is divisible by 2 and 3");
			}
			if(i%5==0&&i%10==0)
			{
				System.out.println(i+" is divisible by 5 and 10");
			}
			if(i==10)
			{
				System.out.println(i+" This is the 10th number in the list");
			}
			if(i%7==0||i%13==0)
			{
				System.out.println(i+" is divisible either 7 or 13 ");
			}
			if(a==c)
			{
				int z=++a;
				System.out.println("The value of a is incremented by 1 and is now equal to "+z);
			}
			else
			{
				System.out.println("a is not incremented since it is not equal to c");
			}
		}
		int a = 5;
		for(int i=0,j=a-1;;i++,j--)
		{
			System.out.println("The values of i and j are "+i+" and"+j);
		}
	}
	
}

