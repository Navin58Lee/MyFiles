package FindTheWinner;
import java.util.*;
public class main {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int a = in.nextInt();
		int [] andrea = new int[a];
		for(int i=0;i<a;i++)
		{
			andrea[i] = in.nextInt();
		}
		int m = in.nextInt();
		int [] maria = new int[m];
		for(int i=0;i<m;i++)
		{
			maria[i] = in.nextInt();
		}
		String s = in.next();
		System.out.println(Solution.winner(andrea, maria, s));
	}
}
