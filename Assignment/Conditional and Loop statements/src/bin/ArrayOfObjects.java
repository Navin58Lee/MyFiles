package bin;
import java.util.*;
class Student
{
	private String name;
	private int age;
public Student(String nam,int ag)
{
	this.name = nam;
	this.age = ag;
}
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
public class ArrayOfObjects {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		Student s [] = new Student[n];
		for(int i=0;i<n;i++)
		{
		System.out.println("Enter the name");
		String name = in.next();
		System.out.println("Enter the age");
		int age = in.nextInt();
		s[i]=new Student(name,age);
		}
		for(int i=0;i<n;i++)
		{
			System.out.println(s[i].getName());
			System.out.println(s[i].getAge());
		}
	}
}
