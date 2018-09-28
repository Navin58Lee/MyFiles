import java.util.*;
public class Third {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("How Many Subjects");
		int num = in.nextInt();
		int [] a = new int[num];
		int total = 0;
		for(int i=0;i<num;i++)
		{
			System.out.println("Enter The marks");
			a[i] = in.nextInt();
			total = total+ a[i];
		}
		float percentage = total/num;
		System.out.println("Total marks = "+total);
		System.out.println("Percentage = "+percentage);
	}
}
