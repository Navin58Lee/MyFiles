package PsychometricTesting;
import java.util.Scanner;
public class main {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int sl = in.nextInt();
		int s[] = new int[sl];
		for(int i =0;i<sl;i++)
		{
			s[i] = in.nextInt();
		}
		int ll = in.nextInt();
		int l [] = new int[ll];
		for(int i=0;i<ll;i++)
		{
			l[i] = in.nextInt();
		}
		int ul = in.nextInt();
		int u [] = new int[ul];
		for(int i=0;i<ul;i++)
		{
			u[i] = in.nextInt();
		}
		System.out.println(Solution.jobOffers(s,l,u));
	}
}
