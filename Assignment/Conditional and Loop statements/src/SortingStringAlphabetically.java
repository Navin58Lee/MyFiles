import java.util.*;
public class SortingStringAlphabetically {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String str = "india is in ind";
        String [] words = str.split(" ");
        int len = words.length;
        String z = "";
        for(int i=0;i<len-1;i++)
        {
        	for(int j=i+1;j<len;j++)
        	{
        		if(words[i].compareTo(words[j])>0)
        		{
        			z = words[i];
        			words[i] = words[j];
        			words[j] = z;
        		}
        	}
        }
        for(int i=0;i<len;i++)
        {
        	System.out.print(words[i]+" ");
        }
	}
}
