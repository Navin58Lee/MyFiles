import java.util.*;
public class Six {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("Enter the string");
        String usn = in.next();
        if(usn.length()!=10)
        {
        	System.out.println("Failure");
        }
        else if((usn.charAt(0)=='2'||usn.charAt(0)=='1')&&(Character.isUpperCase(usn.charAt(1)))&&(Character.isUpperCase(usn.charAt(2)))&&(Character.isDigit(usn.charAt(3)))&&(Character.isDigit(usn.charAt(4)))&&((usn.substring(5,7).equals("CS"))||(usn.substring(5,7).equals("IS"))||(usn.substring(5,7).equals("EC"))||(usn.substring(5,7).equals("ME")))&&(Character.isDigit(usn.charAt(7)))&&(Character.isDigit(usn.charAt(8)))&&(Character.isDigit(usn.charAt(9))))
        		
        		{
        	      System.out.println("Success");
        		}
        else
        {
        	System.out.println("Failure");
        }
	}
}
