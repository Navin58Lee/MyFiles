package HolesInANumber;

public class Solution {
	static int countHoles(int num)
	{
		int sum = 0;
		int n = 0;
	    while(num!=0)
	    {
	    	n = num%10;
	    	if(n==8)
	    	{
	    		sum = sum+2;
	    	}
	    	else if((n==0)||(n==4)||(n==6)||(n==9))
	    	{
	    		sum = sum+1;
	    	}
	    	else
	    	{
	    		sum = sum+0;
	    	}
	    	num = num/10;
	    }
	    return sum;
	}

}
