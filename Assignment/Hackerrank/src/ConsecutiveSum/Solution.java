package ConsecutiveSum;

public class Solution {
	int consecutive(long num)
	{
		int count = 0;
		int sum = 0;
		for(int i=1;i<num;i++)
		{
			int j = i;
			sum = 0;
			while(sum<num)
			{
				sum = sum+j;
				j++;
			}
			if(sum==num)
			{
				count++;
			}
		}
		return count;
	}

}
