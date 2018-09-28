using System;
namespace MediumFive
{
class Hotel
{
    public long hotelId;
    public string briefNote;
    public string hotelName;
    public string photoURL;
    public int starRanking;
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Hotel))
                return false;
            return this.hotelId == ((Hotel)obj).hotelId &&
                this.briefNote == ((Hotel)obj).briefNote &&
                this.hotelName == ((Hotel)obj).hotelName &&
                this.photoURL == ((Hotel)obj).photoURL &&
                this.starRanking == ((Hotel)obj).starRanking;
        }
    }
    class TestMain
    {
        static void Main(string[] args)
        {
            Hotel h1 = new Hotel();
            h1.hotelId = 456;
            h1.briefNote = "Welcome";
            h1.hotelName = "Whatever";
            h1.photoURL = "https://thereisnophotohere/";
            h1.starRanking = 4;
            Hotel h2 = new Hotel();
            h2.hotelId = 456;
            h2.briefNote = "Welcome";
            h2.hotelName = "Whatever";
            h2.photoURL = "https://thereisnophotohere/";
            h2.starRanking = 4;
            Console.WriteLine(h1==h2);
            Console.WriteLine(h1.Equals(h2));
            Console.ReadKey();
        }
    }
}
