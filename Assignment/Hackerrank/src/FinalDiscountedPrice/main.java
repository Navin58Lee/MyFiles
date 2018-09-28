package FinalDiscountedPrice;
import java.util.*;
public class main {
	public static void main(String[] args) {
			Scanner in = new Scanner(System.in);
			int n = in.nextInt();
			int [] prices = new int[n];
			for(int i=0;i<n;i++)
			{
				prices[i] = in.nextInt();
			}
			Solution.finalPrice(prices);
	}
}
