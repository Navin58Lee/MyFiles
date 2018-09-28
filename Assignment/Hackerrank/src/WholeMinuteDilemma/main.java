package WholeMinuteDilemma;
import java.util.*;
public class main {
	public static void main(String[] args) {
	   Scanner in = new Scanner(System.in);
	   int n = in.nextInt();
	   int songs [] = new int[n];
	   for(int i=0;i<n;i++)
	   {
		   songs[i] = in.nextInt();
	   }
	   System.out.println(Solution.playlist(songs));
	}
}
