package PlusMultArray;
import java.util.*;
public class main {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		int A [] = new int[n];
		for(int i=0;i<n;i++)
		{
			A[i] = in.nextInt();
		}
		System.out.println(Solution.plusMult(A));
	}
}
