import java.util.*;
public class Sixteen {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("Enter the string");
		String a = in.next();
		String b = "";
		String c = "";
		String d = "";
		List<String> l = new ArrayList<String>();
		for(int i=0;i<a.length();i++)
		{
			if(Character.isAlphabetic(a.charAt(i)))
			{
			   b = b+a.charAt(i);
			}
		}
		for(int j=0;j<b.length();j++)
		{
			c ="";
			c = c+b.charAt(j);
			l.add(c);
		}
		Collections.sort(l,String.CASE_INSENSITIVE_ORDER);
		for(int k=0;k<l.size();k++)
		{
			d = d+l.get(k);
		}
		System.out.println(d);
	}
}
        
