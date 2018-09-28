package bin;
import java.util.*;
public class TwoDStringArray {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String a = in.nextLine();
		String b = in.nextLine();
		String result = "";
        String [][] arr = new String[2][10];
        String aword[] = a.split(" ");
        String bword[] = b.split(" ");
        for(int i=0;i<aword.length;i++)
        {
        	arr[0][i] = aword[i];
        }
        for(int i=0;i<bword.length;i++)
        {
        	arr[1][i] = bword[i];
        }
        for(int i=0;i<aword.length-1;i++)
        {
        	for(int j=i+1;j<aword.length;j++)
        	if(arr[0][i].compareTo(arr[0][j])>0)
        	{
        		result = arr[0][i];
        		arr[0][i] = arr[0][j];
        		arr[0][j] = result;
        	}
        }
        for(int i=0;i<bword.length-1;i++)
        {
        	for(int j=i+1;j<bword.length;j++)
        	{
        	if(arr[1][i].compareTo(arr[1][i+1])<0)
        	{
        		result = arr[1][i];
        		arr[1][i] = arr[1][j];
        		arr[1][j] = result;
        	}
        	}
        }
        for(int i=0;i<aword.length;i++)
        {
        	System.out.print(arr[0][i]+" ");
        }
        System.out.println();
        for(int i=0;i<bword.length;i++)
        {
            System.out.print(arr[1][i]+" ");
        }
	}
}
