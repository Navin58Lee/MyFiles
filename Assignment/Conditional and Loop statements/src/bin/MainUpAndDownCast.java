package bin;
class Vehicle
{
	public void start()
	{
		System.out.println("Vehicle Started");
	}
}
class Car extends Vehicle
{
	public void start()
	{
		System.out.println("Car Started");
	}
	public void honk()
	{
		System.out.println("Car Honking");
	}
}
public class MainUpAndDownCast {
	public static void main(String[] args) {
		Vehicle vehicle1 = new Vehicle();
		//vehicle1.start();
	    Car car1 = new Car();
	   // car1.start();
	    //car1.honk();
	    //up
	    Vehicle vehicle2 = car1;
	    vehicle2.start();
            //down
	    Vehicle vehicle3 = new Car();
	    Car car2 = (Car)vehicle3;
	    car2.start();
	    car2.honk();
	}
}
