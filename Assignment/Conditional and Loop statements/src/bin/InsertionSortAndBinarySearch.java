package bin;
import java.util.*;
class N
{
	public static void insertionSort(int a [])
	{
		int len = a.length;
		for(int i=1;i<len;i++)
		{
			int k = a[i];
			int j=i-1;
			while(j>=0&&a[j]>k)
			{
				a[j+1] = a[j];
				j--;
			}
			a[j+1] = k;
		}
		for(int i=0;i<len;i++)
		{
			System.out.print(a[i]+" ");
		}
		int b[] = new int[len];
		for(int i=0;i<len;i++)
		{
			b[i] = a[i];
		}
	}
	public static int binarySearch(int b [],int x)
	{
		int len = b.length;
		int start = 0;
		int end = len-1;
		int mid = (start+end)/2;
		while(start<end)
		{
			mid = (start+end)/2;
			if(b[mid] == x)
			{
				return mid;
			}
			if(b[mid]<x)
			{
				start = mid+1;
			}
			else
			{
				end = mid-1;
			}
		}
		return -1;
	}
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("Enter the number of elements");
		int n = in.nextInt();
		System.out.println("Enter the elements of the array");
		int a[] = new int[n];
		for(int i=0;i<n;i++)
		{
			a[i] = in.nextInt();
		}
		N.insertionSort(a);
		System.out.println("Enter the element to be searched");
		int x = in.nextInt();
		int result = N.binarySearch(a, x);
		if(result==-1)
		{
			System.out.println("Element not found");
		}
		else
		{
			System.out.println(result);
		}
	}

}
