package CountDuplicates;

public class Solution {
	static int countDuplicates(int [] number)
	{
		int n = number.length;
	    int s = 0;
	    int count =0;
	    int dummy = -5555;
	    for(int i=0;i<n;i++)
	    {
	    	s = 0;
	      if(number[i]!=dummy)
	      {
	    	  for(int j=i+1;j<n;j++)
	    	  {
	    		  if(number[i]==number[j])
	    		  {
	    			        s++;
	    			        number[j]=dummy;
	    	      }
	    	  }
	      }
	      if(s>0)
	      {
	    	  count++;
	      }
	    }
	    return count;
	}
}
