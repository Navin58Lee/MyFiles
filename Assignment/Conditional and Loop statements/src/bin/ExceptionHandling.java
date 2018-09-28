package bin;
import java.util.*;
public class ExceptionHandling {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int num = 100;
		int result = 0;
		try{
		for(int i=10;i>=0;i--)
		{
			result = num/i;
	        System.out.println(result);
		}
		}
		catch(Exception n)
		{
			System.out.println(n.toString());
		}
	    int a[] = {1,2,3,4,5};
	    try
	    {
	    for(int i=0;i<10;i++)
	    {
	    	System.out.println(a[i]);
	    }
	    }
	    catch(Exception n)
	    {
	    	System.out.println(n.toString());
	    }
	        String name = in.next();
	        int count = 0;
	    	int len = name.length();
	    	for(int i=0;i<len;i++)
	    	{
	    		if(name.charAt(i)>=65 && name.charAt(i)<=122)
	    		{
	    			count = count+1;
	    		}
	    	}
	    	if(count == len)
	    	{
	    		System.out.println(name);
	    	}
	    	else
	    	{
	    		System.out.println("Name cannot contain any number or special character");
	    	}
	}
}
