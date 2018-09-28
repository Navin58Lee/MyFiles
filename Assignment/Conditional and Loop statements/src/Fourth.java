import java.util.*;
public class Fourth {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("How may rows,colums?");
		int r = in.nextInt();
		int c = in.nextInt();
		int[][] arr = new int[r][c];
		System.out.println("Enter elements of matrix");
		for(int i=0;i<r;i++)
		{
			for(int j=0;j<c;j++)
			{
				arr[i][j] = in.nextInt();
			}
		}
        System.out.println("The Transpose of the matrix is");
        for(int i=0;i<c;i++)
        {
        	for(int j=0;j<r;j++)
        	{
        		System.out.print(arr[j][i]+" ");
        	}
        	System.out.println("\n");
        } 
	}
}
