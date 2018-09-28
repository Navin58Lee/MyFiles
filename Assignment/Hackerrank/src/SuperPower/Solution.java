package SuperPower;
public class Solution {
	static int superPower(int z)
	{
		int count = 0;
		for(int i=1;i<z/2;i++)
		{
			if(i*i==z)
			{
				count = 1;
				break;
			}
		}
		return count;
	}
}