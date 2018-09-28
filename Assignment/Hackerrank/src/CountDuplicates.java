import java.util.*;
public class CountDuplicates {

	public static void main(String[] args) 
	{
	    Scanner in = new Scanner(System.in);
	    int n = in.nextInt();
	    int [] number = new int[n];
	    for(int i=0;i<n;i++)
	    {
	    	number[i] = in.nextInt();
	    }  
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
	    System.out.println(count);
	}
}
       