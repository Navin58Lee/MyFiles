package MinimumAmount;
import java.util.Scanner;
public class main {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int num = in.nextInt();
		int [] prices = new int[num];
		int a,b;
		for(int i = 0;i<num;i++)
		{
			prices[i] = in.nextInt();
			
		}
		System.out.println(Solution.calculateAmount(prices));
	}
}
