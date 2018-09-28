import java.util.*;
public class PsychometricExample {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int sl = in.nextInt();
		int s[] = new int[sl];
		for(int i =0;i<sl;i++)
		{
			s[i] = in.nextInt();
		}
		int ll = in.nextInt();
		int l [] = new int[ll];
		for(int i=0;i<ll;i++)
		{
			l[i] = in.nextInt();
		}
		int ul = in.nextInt();
		int u [] = new int[ul];
		for(int i=0;i<ul;i++)
		{
			u[i] = in.nextInt();
		}
		 int count = 0;
		 int res [] = new int[ll];
		 for(int i=0;i<ll;i++)
		 {
			 int x = l[i];
			 int y = u[i];
			 count = 0;
			 for(int j=0;j<sl;j++)
			 {
				 for(int k=x;k<=y;k++)
				 {
					 if(s[j]==k)
					 {
						 count++;
					 }
				 }
			 }
			 res[i] = count;
		 }
		 for(int i=0;i<ll;i++)
		 {
			 System.out.print(res[i]+" ");
		 }
	}
}
