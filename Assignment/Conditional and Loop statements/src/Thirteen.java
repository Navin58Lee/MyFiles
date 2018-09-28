import java.util.*;
public class Thirteen {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("Enter the string");
		String s = in.nextLine();
		String empty = "";
		String [] word = s.split(" ");
		for(int i=0;i<word.length;i++)	
		{
			empty = empty+word[i];
		}
	    String upper = empty.toUpperCase();
	    int len = upper.length();
	    for(int i=1;i<len;i++)
	    {
	    	int n1 = (int)upper.charAt(i-1);
	    	int n2 = (int)upper.charAt(i);
	    	if(n2==(n1+1))
	    	{
	    		System.out.println((char)n1+""+ (char)n2);   		
	    	}
	    }
	}
}
