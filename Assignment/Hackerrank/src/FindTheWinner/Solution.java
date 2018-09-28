package FindTheWinner;

public class Solution {
	 static String winner(int[] andrea, int[] maria, String s) {
		 int asum = 0;
	        int msum = 0;
	        if(s.equals("Even"))
	        {
	        	for(int i=0;i<andrea.length;i++)
	        	{
	                if(i%2==0)
	                {
	        		asum = asum+(andrea[i] - maria[i]);
	        		msum = msum+(maria[i] - andrea[i]);
	                }
	        	}
	        }
	        if(s.equals("Odd"))
	        {
	        	for(int i=0;i<andrea.length;i++)
	        	{
	                if(i%2!=0)
	                {
	        		asum = asum+(andrea[i] - maria[i]);
	        		msum = msum+(maria[i] - andrea[i]);
	                }
	        	}
	        }
	        	if(asum>msum)
	        	{
	        	   return "Andrea";
	        	}
	        	else if(msum>asum)
	        	{
	        		return "Maria";
	        	}
	            else
	            {
	                return "Tie";
	            }
	    }

}
