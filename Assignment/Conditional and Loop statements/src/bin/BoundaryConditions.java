package bin;
import java.util.*;
public class BoundaryConditions {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
	    System.out.println("Enter your name");
	    String nam = in.next();
	    int len = nam.length();
	    int count = 0;
	    for(int i=0;i<len;i++)
	    {
	    	if(nam.charAt(i)>=65 && nam.charAt(i)<=122)
	    	{
	    		count = count+1;
	    	}
	    }
	    if(count == len)
	    {
	    	System.out.println("Your name is: "+nam);
	    }
	    else
	    {
	    	System.out.println("Name cannot contain any number or special character");
	    }
	}
}
