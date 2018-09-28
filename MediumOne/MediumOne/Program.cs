using System;
namespace MediumOne
{
    class Hotel
    {
        public long hotelId;
        public string briefNote;
        public string hotelName;
        public string photoURL;
        public int starRanking;
        public long getHotelId()
        {
            return hotelId;
        }
        public void setHotelId(long hid)
        {
            hotelId = hid;
        }
        public string getBriefNote()
        {
            return briefNote;
        }
        public void setBriefNote(string bn)
        {
            briefNote = bn;
        }
        public string getHotelName()
        {
            return hotelName;
        }
        public void setHotelName(string hName)
        {
            hotelName = hName;
        }
        public string getPhotoUrl()
        {
            return photoURL;
        }
        public void setPhotpoUrl(string purl)
        {
            photoURL = purl;
        }
        public int getStarRanking()
        {
            return starRanking;
        }
        public void setStarRanking(int sr)
        {
            starRanking = sr;
        }
    }
    class HotelMgr
    {
        public static void showData(Hotel h)
        {
            Console.WriteLine("Enter hotel ID");
            h.hotelId = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the brief note");
            h.briefNote = Console.ReadLine();
            Console.WriteLine("Enter the hotel name");
            h.hotelName = Console.ReadLine();
            Console.WriteLine("Enter photo URL");
            h.photoURL = Console.ReadLine();
            Console.WriteLine("Enter the star ranking");
            h.starRanking = int.Parse(Console.ReadLine());
        }
        public static void storeData(Hotel h)
        {
            Console.WriteLine("Hotel ID : "+h.hotelId);
            Console.WriteLine("Brief Note : "+h.briefNote);
            Console.WriteLine("Hotel Name : "+h.hotelName);
            Console.WriteLine("Photo URL : "+h.photoURL);
            Console.WriteLine("Star Ranking : "+h.starRanking);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hotel h = new Hotel();
            HotelMgr.showData(h);
            HotelMgr.storeData(h);
            Console.ReadKey();
        }
    }
}
