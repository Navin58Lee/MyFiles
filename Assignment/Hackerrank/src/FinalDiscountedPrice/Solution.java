package FinalDiscountedPrice;
public class Solution {
	static void finalPrice(int [] prices)
	{
		int len = prices.length;
		int temp = 0;
		int sum = 0;
		int min;
		for(int i=0;i<len;i++)
		{
			int k = i+1;
			min = prices[k];
			for(int j=k+1;j<len;j++)
			{
				if(prices[j]<min)
				{
					min = prices[j];
				}
			}
			if(prices[i]>min)
			{
				sum = sum+(prices[i]-min);
			}
			if(prices[i] == min)
			{
				sum = sum+0;
			}
			if(prices[i]<min)
			{
				sum = sum+prices[i];
			}
		}
		System.out.println(sum);
	}
}
