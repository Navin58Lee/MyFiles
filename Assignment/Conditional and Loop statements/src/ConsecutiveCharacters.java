import java.util.*;
public class ConsecutiveCharacters {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String str = in.next();
		String res = "";
		int len  = str.length();
		for(int i=1;i<len-1;i++)
		{
			{
				if(str.charAt(i)-str.charAt(i-1)==1)
				{
				  res = res+"*";
				}
				else
				{
					res = res+str.charAt(i);
				}
			}
		}
		System.out.println(res);
	}
}
