package MonsoonUmbrellas;
public class Solution {
	static int getUmbrellas(int n, int[] p) {
		int len = p.length;
		int result = 0;
		for(int i=0;i<len;i++)
		{
			if(p[i] == n)
			{
				result = 1;
				break;
			}
			else
			{
				result = -1;
			}
		
		}
	 return result;
    }
}
