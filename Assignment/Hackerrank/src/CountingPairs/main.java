package CountingPairs;
import java.util.*;
public class main {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		int numbers [] = new int[n];
		for(int i=0;i<n;i++)
		{
			numbers[i] = in.nextInt();
		}
		int k = in.nextInt();
		System.out.println(Solution.countPairs(numbers, k));
	}

}
