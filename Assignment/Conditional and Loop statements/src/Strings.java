import java.util.*;
public class Strings {

	public static void main(String[] args) {
		/*
		String s1 = "Mindtree";
		String s2 = "Mindtree";
		String s3 = new String("Mindtree");
		String s4 = "Kalinga";
		System.out.println(s1==s2);
		System.out.println(s1==s3);
		System.out.println(s1==s4);
		System.out.println(s1.equals(s2));
		System.out.println(s1.equals(s3));
		System.out.println(s1.equals(s4));
		
		String s1 = "Mindtree";
		String s3 = new String("Mindtree");
		String s2 = "MINDTREE";
		*/
		/*
		String s = "Mindtree";
		char[] ch = s.tocharArray();
		
		int i;
		for(i=0;i<s.length();i++)
		{
			if((ch[i]>=97))&&(ch[i]<=122))
			{
				ch[i] = ch[i]-32;
			}
		}
		*/
		/*
		String s1 = "aBC";
		String s2 = "ABC";
		String s3 = "ACB";
		System.out.println(s1.compareTo(s2));
		System.out.println(s1.compareTo(s3));
		System.out.println(s3.compareTo(s1));
		*/
	    StringBuffer sb = new StringBuffer("Hello ");
	    long startTime = System.currentTimeMillis();
	    sb.append("World");
	    System.out.println(System.currentTimeMillis()-startTime);
	    System.out.println(sb);
		
		
		
		
		
		
		
		
	}

}
