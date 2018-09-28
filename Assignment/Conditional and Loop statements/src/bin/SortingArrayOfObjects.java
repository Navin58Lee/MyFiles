package bin;
import java.util.*;
class Students
{
	private String name;
	private int age;
public Students(String nam)
{
	this.name = nam;
}
public String getName()
{
	return name;
}
public void setName(String name)
{
    this.name = name;
}
}
public class SortingArrayOfObjects {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		Students s [][] = new Students[2][n];
		Students s1[][] = new Students[2][n];
		Students s2[][] = new Students[2][n];
		for(int i=0;i<2;i++)
		{
			for(int j=0;j<n;j++)
			{
				String name = in.next();
				s[i][j]=new Students(name);
			}
		}
		for(int i=0;i<n-1;i++)
		{
			for(int j=i+1;j<n;j++)
			{
                if((s[0][i].getName()).compareTo(s[0][j].getName())>0)
				{
					s1[0][i] = s[0][j];
					s[0][j] = s[0][i];
					s[0][i] = s1[0][i];
				}
			}
		}
			for(int j=0;j<n;j++)
			{
				System.out.print(s[0][j].getName()+" ");
			}
			System.out.println();
		for(int i=0;i<n-1;i++)
		{
			for(int j=i+1;j<n;j++)
			{
                if(s[1][i].getName().compareTo(s[1][j].getName())<0)
				{
					s2[1][i] = s[1][i];
					s[1][i] = s[1][j];
					s[1][j] = s2[1][i];
				}
			}
		}
	

			for(int j=0;j<n;j++)
			{
				System.out.print(s[1][j].getName()+" ");
			}	
		
	}
}
