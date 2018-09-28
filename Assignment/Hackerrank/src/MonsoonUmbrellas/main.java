package MonsoonUmbrellas;
import java.util.*;
public class main {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int m = in.nextInt();
        int p [] = new int[m];
        for(int i=0;i<m;i++)
        {
        	p[i] = in.nextInt();
        }
        System.out.println(Solution.getUmbrellas(n, p));
	}
}
