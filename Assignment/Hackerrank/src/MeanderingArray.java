import java.util.*;
public class MeanderingArray {

	public static void main(String[] args) {
	 Scanner in = new Scanner(System.in);
	 int n = in.nextInt();
	 int [] num = new int[n];
	 for(int i=0;i<n;i++)
	 {
		 num[i] = in.nextInt();
	 }
	 int [] res = new int[n];
	 for(int i=0;i<n-1;i++)
	 {
		 for(int j=i+1;j<n;j++)
		 {
		 if(num[i]>num[j])
		 {
			 int temp = num[i];
			 num[i] = num[j];
			 num[j] = temp;
		 }
		 }
	 }
	 int x = 0;
	 for(int i=n-1;i>=n/2;i--)
	 {
		 res[x] = num[i];
		 x = x+2;
	 }
	 int y=1;
	 for(int i=0;i<n/2;i++)
	 {
		 res[y] = num[i];
		 y = y+2;
	 }
	 for(int i=0;i<n;i++)
	 {
		 System.out.print(num[i]+" ");
	 }
	 System.out.println();
	 for(int i=0;i<n;i++)
	 {
		 System.out.print(res[i]+" ");
	 }
	}
}
