package UsernamesSystem;

public class Solution {
	 static String[] usernamesSystem(String[] u) {
	  int n = u.length;
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
	  return u;
	 }
}