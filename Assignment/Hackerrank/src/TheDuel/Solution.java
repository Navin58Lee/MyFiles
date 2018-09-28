package TheDuel;
public class Solution {
    static void minPower(int[] p) {
    int len = p.length;
    int sum = 0;
    for(int i=1;i<100;i++)
    {
    	sum = i;
       for(int j=0;j<len;j++)
       {
    	   while(sum>0)
    	   {
    	    sum = sum+p[j];
    	   }
       }
       if(sum>0)
       {
    	   System.out.println(i);
       }
    }
    }
}
