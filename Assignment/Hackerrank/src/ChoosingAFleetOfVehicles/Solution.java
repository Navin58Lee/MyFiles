package ChoosingAFleetOfVehicles;
public class Solution {
    static int[] chooseFleets(int[] wheels) {
    int len = wheels.length;
    int res[] = new int[len];
    for(int i=0;i<len;i++)
    {
    	if(wheels[i]==2)
    	{
    		res[i] = 1;
    	}
    	if(wheels[i]%2==0)
    	{
    		res[i] = (wheels[i]/4)+1;
    	}
    	if(wheels[i]%2!=0)
    	{
    		res[i] = 0;
    	}
    }
   return res;
    }
}
