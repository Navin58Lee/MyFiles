import java.util.*;
public class Test 
{
	public static void main(String[] args)
	{
		Scanner in = new Scanner(System.in);
		int n = 14;
		int count = 0;
		while(n!=1)
		{
			if(n%2==0)
			{
				int evennum = n/2;
				System.out.print(n+"   is even so i take half: "+"\t"+evennum+"\n");
				n = evennum;
				count++;
			}
			else
			{
				int oddnum = (3*n)+1;
				System.out.print(n+"   is odd so i make 3n+1: "+"\t"+oddnum+"\n");
				n = oddnum;
				count++;
			}
		}
			if(n==1)
			{
				System.out.println("There are "+count+" steps to reach 1" );
			}
		}
	}


