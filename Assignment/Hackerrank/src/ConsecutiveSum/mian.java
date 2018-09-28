package ConsecutiveSum;
import java.util.*;
public class mian {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int num = in.nextInt();
		Solution ob = new Solution();
		int res = ob.consecutive(num);
		System.out.println(res);
	}
}
