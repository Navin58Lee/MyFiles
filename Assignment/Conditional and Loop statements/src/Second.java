import java.util.*;
public class Second 
{
	public static void main(String[] args) 
	{
		Scanner in = new Scanner(System.in);
		int[] a = new int[10];
		System.out.println("Enter the size of the Array");
		int n = in.nextInt();
		System.out.println("Enter the Data in Array");
		for(int i=0;i<n;i++)
		{
			a[i] = in.nextInt();
		}
		System.out.println("Elements of array A is");
		for(int j=0;j<n;j++)
		{
			System.out.println(a[j]);
		}
		for(int x=0;x<n;x++)
		{
			for(int y=x+1;y<n;y++)
			{
				if(a[x]==a[y])
					
				{
					a[y]=a[n-1];
					n--;
					y--;
				}
			}
		}
		int[] b = new int[n];
		for(int i=0;i<n;i++)
		{
			b[i]=a[i];
		}
		System.out.println("After Deleting Duplicate Elements");
		for(int z=0;z<n;z++)
		{
			System.out.println(b[z]);
		}
	}
}
