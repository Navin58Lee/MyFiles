 import java.util.*;
 public class Seven {
 public static void main(String[] args)  {
		Scanner in = new Scanner(System.in);
		System.out.println("Enter the size of the first array");
		int x = in.nextInt();
		System.out.println("Enter the size of the second array");
		int y = in.nextInt();
		int z;
		double[] a = new double[x];
		double[] b = new double[y];
		System.out.println("Enter the elements of the first array");
		for(int i=0;i<x;i++)
		{
			a[i] = in.nextInt();
		}
		System.out.println("Enter the elements of the second array");
		for(int j=0;j<y;j++)
		{
			b[j] = in.nextInt();
		}
        if(x>y) 
        {
            z = x;
        }
        else
        {
            z = y;
        }
        int[] result = new int[z];
       
        
        for(int k=0;k<z;k++)
        try
        {
        	result[k] = (int)a[k]+(int)b[k];
        }
        catch(ArrayIndexOutOfBoundsException g)
        {
        	if(z==x)
        	{
        		result[k] = (int)a[k];
        	}
        	else
        		
        	{
        		result[k] = (int)b[k];
        	}
        }
        System.out.println("The resultant array is ");
        for(int n=0;n<z;n++)
        {
        	System.out.print(result[n]+" ");
        }
	}
}


