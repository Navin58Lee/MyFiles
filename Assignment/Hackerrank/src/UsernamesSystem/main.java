package UsernamesSystem;
import java.util.*;
public class main {

	public static void main(String[] args) {
		 Scanner in = new Scanner(System.in);
		  int n = in.nextInt();
		  String [] u = new String[n];
		  for(int i=0;i<n;i++)
		  {
			  u[i] = in.next();
		  }
	  System.out.println(Solution.usernamesSystem(u));
	}
}
