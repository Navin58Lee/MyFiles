import java.util.*;
public class Problem {
	public static void main(String[] args) {
		String name = "Naveen";
		int len = name.length();
        char [] a = new char[len];
        for(int i=0;i<len;i++)
        {
        	a[i] = name.charAt(i);
        }
        for(int i=0;i<len;i++)
        {
        	System.out.print(a[i]);
        }
        System.out.println();
    char [] m = {'M','1','0','4','7','2','5','6'};
    int ml = m.length;
    int l = len+ml;
    char [] res = new char[l];
    for(int i=0;i<len;i++)
    {
    	res[i] = a[i];
    }
    int s = 6;
    for(int j=0;j<ml;j++)
    {
    	res[s] = m[j];
    	s++;
    }
    for(int k=0;k<l;k++)
    {
    	System.out.print(res[k]+" ");
    }
}
}
