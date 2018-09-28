package PlusMultArray;

public class Solution {
	static String plusMult(int [] A)
	{
		int len = A.length;
		int esum = 0;
		int osum = 0;
		int a = 0;
		int b = 0;
		String result = "";
		for(int i=0;i<len;i++)
		{
			if(i%2==0)
			{
				if(a==0)
				{
					esum = esum+A[i];
					a++;
				}
				else
				{
					esum = esum*A[i];
					a=0;
				}			
			}
			if(i%2!=0)
			{
				if(b==0)
				{
					osum = osum+A[i];
					b++;
				}
				else
				{
					osum = osum*A[i];
				}
			}
		}
		esum = esum%2;
		osum = osum%2;
		if(esum>osum)
			result = "EVEN";
		if(osum>esum)
			result = "ODD";
		if(esum==osum)
			result = "NEUTRAL";
	return result;
	}
}
