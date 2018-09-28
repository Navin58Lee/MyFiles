package MeanderingArray;

public class Solution {
	 static int[] meanderingArray(int[] num)
	 {
		 int n = num.length;
		 int [] res = new int[n];
		 for(int i=0;i<n-1;i++)
		 {
			 for(int j=i+1;j<n;j++)
			 {
			 if(num[i]>num[j])
			 {
				 int temp = num[i];
				 num[i] = num[j];
				 num[j] = temp;
			 }
			 }
		 }
		 int x = 0;
		 for(int i=n-1;i>=n/2;i--)
		 {
			 res[x] = num[i];
			 x = x+2;
		 }
		 int y=1;
		 for(int i=0;i<n/2;i++)
		 {
			 res[y] = num[i];
			 y = y+2;
		 }
	 return res;
}
}
