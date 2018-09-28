using System;
namespace MediumThree
{
    class HotelBooking
    {
    public long bookingId;
    public float costPerDay;
    public string fromDate;
    public string toDate;
    public int noOfPersons;
    public int noOfRooms;
    public HotelBooking(long bid,float cpd,string fd,string td,int nop,int nor)
    {
        bookingId = bid;
        costPerDay = cpd;
        fromDate = fd;
        toDate = td;
        noOfPersons = nop;
        noOfRooms = nor;
    }
    }
class HotelBookingManager
{
    public static void showBookingDetails(HotelBooking h)
    {
        Console.WriteLine("Booking ID : " + h.bookingId);
        Console.WriteLine("Cost Per Day : " + h.costPerDay);
        Console.WriteLine("From Date : " + h.fromDate);
        Console.WriteLine("To Date : " + h.toDate);
        Console.WriteLine("No of Persons : " + h.noOfPersons);
        Console.WriteLine("No of Rooms : " + h.noOfRooms);
    }
    public static HotelBooking createBooking()
    {
            HotelBooking h = new HotelBooking(5473, 2199, "30/12/2018", "02/01/2019", 5, 2);
        return h;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            HotelBooking h = HotelBookingManager.createBooking();
            HotelBookingManager.showBookingDetails(h);
            Console.ReadKey();
        }
    }
}
