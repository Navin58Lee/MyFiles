package bin;
import java.util.*;

public class ArrayOfObjects1{
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		Student123 s [] = new Student123[n];
		for(int i=0;i<n;i++)
		{
		System.out.println("Enter the name");
		s[i]=new Student123();
		s[i].setName(in.next());
		System.out.println("Enter the age");
		s[i].setAge(in.nextInt());
		//s[i].setAge(age);
		}
	}
}
class Student123
{
	private String name;
	private int age;
	
	
public String getName()
{
	return name;
}
public void setName(String name)
{
    this.name = name;
}
public int getAge()
{
	return age;
}
public void setAge(int age)
{
	this.age = age;
}
}