package TheRestructuredArray;
import java.util.*;
public class main {

	public static void main(String[] args) {
		Scanner in =  new Scanner(System.in);
		int n = in.nextInt();
		int num [] = new int[n];
		for(int i=0;i<n;i++)
		{
			num[i] = in.nextInt();
		}
		int input = in.nextInt();
		int brr[][] = new int[input][2];
		for(int i=0;i<input;i++)
		{
			for(int j=0;j<2;j++)
			{
				brr[i][j] = in.nextInt();
			}
		}
        int c = num[0];
        int r = (n-1)/c;
        int arr [][] = new int[r][c];
        int k = 1;
        for(int i=0;i<r;i++)
        {
        	for(int j=0;j<c;j++)
        	{
        		arr[i][j] = num[k];
        		k++;
        	}
        }
        for(int i=0;i<c;i++)
        {
        	for(int j=0;j<r;j++)
        	{
        		System.out.println(arr[j][i]+" ");
        	}
        } 
	}
}
