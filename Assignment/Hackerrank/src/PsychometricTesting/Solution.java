package PsychometricTesting;

public class Solution {
	 static int[] jobOffers(int[] s, int[] l, int[] u) {
		 int slen = s.length;
		 int llen = l.length;
		 int ulen = u.length;
		 int count=0;
		 int res [] = new int[llen];
		 for(int i=0;i<llen;i++)
		 {
			 int x = l[i];
			 int y = u[i];
			 count = 0;
			 for(int j=0;j<slen;j++)
			 {
				 for(int k=x;k<=y;k++)
				 {
					 if(s[j]==k)
					 {
						 count++;
					 }
				 }
			 }
	        	 res[i]=count;
		 }
	    }
	 return res;
}
