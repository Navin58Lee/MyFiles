package TheDuel;
import java.util.*;
public class main {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		int p [] = new int[n];
		for(int i=0;i<n;i++)
		{
			p[i] = in.nextInt();
		}
        Solution.minPower(p);
	}
}
