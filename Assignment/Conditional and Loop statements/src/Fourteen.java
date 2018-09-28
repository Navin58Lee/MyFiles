import java.util.*;
public class Fourteen {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("Enter the number of elements in the array");
		int num = in.nextInt();
		int [] a = new int[num];
		System.out.println("Enter the elements");
		for(int i=0;i<num;i++)	
		{
			a[i] = in.nextInt();
		}
		for(int i=0;i<num;i++)
		{
			for(int j=i+1;j<num-1;j++)
			{
				for(int k=j+1;k<num;k++)
				{
					if(a[i]+a[j]==a[k])
					{
						System.out.println(a[i]+" "+a[j]+" "+a[k]);
					}
				}
			}
		}
		
	}
}
