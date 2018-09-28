import java.util.*;
public class Seventeen {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("Enter the string");
		String s = in.nextLine();
		String [] word = s.split(" ");
		int len = word.length;
		String reverse = "";
        for(int i=0;i<word.length;i++)
        {
        	String n = word[i];
        	String r = "";
        	for(int j=len-1;j>=0;j--)
        	{
        		r = r+n.charAt(j);
        	}
        	reverse = reverse+r;
        } 
        System.out.println(reverse);
   }
}