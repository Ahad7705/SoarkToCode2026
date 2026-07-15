namespace Hotel_Management_System_part2
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public void DisplayRoom()
        {
            Console.WriteLine("Room Number: " + RoomNumber);
            Console.WriteLine("Room Type: " + RoomType);
            Console.WriteLine("Price Per Night: " + PricePerNight);
            Console.WriteLine("Available: " + IsAvailable);
        }
    }
    public class Guest
    {
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        public void DisplayGuest()
        {
            Console.WriteLine("Guest ID: " + GuestId);
            Console.WriteLine("Guest Name: " + GuestName);
        }

        public double CalculateTotalCost(double pricePerNight)
        {
            return pricePerNight * TotalNights;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
