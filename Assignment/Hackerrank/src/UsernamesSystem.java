import java.util.*;
public class UsernamesSystem {
	public static void main(String[] args) {
	  Scanner in = new Scanner(System.in);
	  int n = in.nextInt();
	  String [] u = new String[n];
	  for(int i=0;i<n;i++)
	  {
		  u[i] = in.next();
	  }
	  int count = 1;
	  for(int i=0;i<n-1;i++)
	  {
		  count = 1;
		  for(int j=i+1;j<n;j++)
		  {
			if(u[i].equals(u[j]))
			{
				u[j] = u[j]+count;
				count++;
			}
		  }
	  }
	  for(int i=0;i<n;i++)
	  {
		  System.out.print(u[i]+" ");
	  }
	}
}
