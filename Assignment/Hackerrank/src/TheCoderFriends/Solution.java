package TheCoderFriends;

public class Solution {
    static String winner(String erica,String bob)
    {
	int e = 0;
	int b = 0;
	String s1 = "Erica";
	String s2 = "Bob";
	String res = "";
	int l1 = erica.length();
	int l2 = bob.length();
	for(int i=0;i<l1;i++)
	{
		if(erica.charAt(i)=='E')
		   e = e+1;
		else if(erica.charAt(i)=='M')
			e = e+3;
		else
			e = e+5;
	}
	for(int j=0;j<l2;j++)
	{
		if(bob.charAt(j)=='E')
			b = b+1;
		else if(bob.charAt(j)=='M')
			b = b+3;
		else
			b = b+5;
	}
	if(e>b)
	{
	   res = res+s1;
	   return res;
	}
	else
	{
		res = res+s2;
		return res;
	}
}
}