import java.util.*;
public class Five {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("Enter the number of elements");
		int n = in.nextInt();
		int[] arr = new int[n];
	    System.out.println("Enter the elements of the array");
		for(int x=0;x<n;x++)
		{
			arr[x] = in.nextInt();
		}
		for(int i=0;i<n-1;i++)
		{
			for(int j=0;j<n-i-1;j++)
			{
				if(arr[j]>arr[j+1])
				{
					int temp = arr[j];
					arr[j] = arr[j+1];
					arr[j+1] = temp;
				}
			}
		}
		System.out.println("The sorted array is as follows");
        for(int k=0;k<n;k++)   	
        {
        	System.out.print(arr[k]+" ");
        }
	}

}
