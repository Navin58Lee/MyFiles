package CountingPairs;
import java.util.*;
public class Solution {
	 static int countPairs(int[] numbers, int k) {
		 int l = numbers.length;
		 int count = 0;
		 int x = 0;
		 Arrays.sort(numbers);
		 for(int i=0;i<l-1;i++)
		 {
			 for(int j=i+1;j<l;j++)
			 {
				 if(numbers[i]+k<numbers[j])
				 {
					 break;
				 }
				 else if((numbers[i]+k==numbers[j])&&(x!=numbers[i]+k))
				 {
					 x = numbers[i]+k;
					 count = count+1;
					 break;
				 }
			 }
		 }
		 return count;
	    } 
}
