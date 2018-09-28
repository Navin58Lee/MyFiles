import java.util.*;
public class Eighteen {

	public static void main(String[] args) {
	      Scanner in = new Scanner(System.in);
	      System.out.println("Enter the numbers");
	      List<Integer> l = new ArrayList<Integer>();
	      int a = 1;
	      while(a!=0)
	      {
	    	  String s = in.next();
	    	  a = Integer.parseInt(s);
	    	  if(a!=0)
	    	  {
	    		  l.add(a);
	    	  } 
	      }
	      try
	      {
	    	  System.out.println("Max and Min is"+Collections.max(l)+Collections.min(l));
	      }
	      catch(Exception h)
	      {
	    	  System.out.println("NULL");
	      }

	}
}
