package WholeMinuteDilemma;

public class Solution {
	  static long playlist(int[] songs) {
      int len = songs.length;
      int count = 0;
      for(int i=0;i<len-1;i++)
      {
    	  for(int j=i+1;j<len;j++)
    	  {
    		  if((songs[i]+songs[j])%60==0)
    		  {
    			  count++;
    		  }
    	  }
      }
      return count;
	  }
}
