package ChoosingAFleetOfVehicles;
import java.util.*;
public class main {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		int [] wheels = new int[n];
		for(int i=0;i<n;i++)
		{
			wheels[i] = in.nextInt();
		}
		int a[] = new int[n];
		a = Solution.chooseFleets(wheels);
		for(int i=0;i<n;i++)
		{
			System.out.print(a[i]+" ");
		}
		in.close();
	}
}
