package CountDuplicates;

import java.util.Scanner;

public class main {

	public static void main(String[] args) {
		 Scanner in = new Scanner(System.in);
		    int n = in.nextInt();
		    int [] number = new int[n];
		    for(int i=0;i<n;i++)
		    {
		    	number[i] = in.nextInt();
		    }  
		    System.out.println(Solution.countDuplicates(number));
	}
}
