package MinimumAmount;

public class Solution {
    static long calculateAmount(int[] prices) {
      int n = prices.length;
      int min = 0;
      int sum = 0;
      for(int i=2;i<n;i++)
      {
    	  for(int j=i;j>0;j--)
    	  {
    		  if(prices[j]<prices[j-1])
    		  {
    			  int temp = prices[j];
    			  prices[j] = prices[j-1];
    			  prices[j-1] = temp;
    		  }
    	  }
    	  min = prices[0];
    	  if(prices[i]<min)
    	  {
    		  sum = sum+0;
    	  }
    	  if(prices[i]>min)
    	  {
    		  sum = sum+prices[i];
    	  } 
      }
      sum = sum+prices[0];
      sum = sum+(prices[1]-prices[0]);
      return sum;
      }
}
