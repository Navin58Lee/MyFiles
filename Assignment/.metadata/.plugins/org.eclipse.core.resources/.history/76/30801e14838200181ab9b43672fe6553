package FindTheFirstRepeatedWordInASentence;

public class Solution {
	static String firstRepeatedWord(String s)
	{
		String [] words = s.split(" ");
		int len = words.length;
		String r = "";
		int count = 0;
		for(int i=0;i<len-1;i++)
		{
			for(int j=i+1;j<len;j++)
			{
				if(count == 0)
				{
				if(words[i].equals(words[j]))
				{
					r = words[i];
					count++;
				}
				}
			}
		}
		return r;
	}

}
