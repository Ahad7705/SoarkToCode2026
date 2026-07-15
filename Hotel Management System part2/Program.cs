using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            rooms.Add(new Room
            {
                RoomNumber = 101,
                RoomType = "Single",
                PricePerNight = 25,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 102,
                RoomType = "Single",
                PricePerNight = 30,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 201,
                RoomType = "Double",
                PricePerNight = 40,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 202,
                RoomType = "Double",
                PricePerNight = 45,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 301,
                RoomType = "Suite",
                PricePerNight = 80,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 302,
                RoomType = "Suite",
                PricePerNight = 90,
                IsAvailable = true
            });
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("GRAND VISTA HOTEL - MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");

                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");

                Console.WriteLine("================================================");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddNewRoom(rooms);
                        break;

                    case 2:
                        RegisterNewGuest(guests);
                        break;

                    case 3:
                        BookRoomForGuest(guests, rooms);
                        break;

                    case 4:
                        ViewAllRooms(rooms);
                        break;

                    case 5:
                        ViewAllGuests(guests);
                        break;

                    case 0:
                        exitApp = true;
                        break;
                }
            }
            static void AddNewRoom(List<Room> rooms)
            {
                Console.Write("Enter Room Number: ");
                int roomNumber = Convert.ToInt32(Console.ReadLine());

                if (rooms.Any(r => r.RoomNumber == roomNumber))
                {
                    Console.WriteLine("Room number already exists.");
                    return;
                }

                Console.Write("Enter Room Type: ");
                string roomType = Console.ReadLine();

                Console.Write("Enter Price Per Night: ");
                double price = Convert.ToDouble(Console.ReadLine());

                if (price <= 0)
                {
                    Console.WriteLine("Price must be greater than zero.");
                    return;
                }

                Room room = new Room
                {
                    RoomNumber = roomNumber,
                    RoomType = roomType,
                    PricePerNight = price,
                    IsAvailable = true
                };

                rooms.Add(room);

                Console.WriteLine("Room added successfully.");
                Console.WriteLine("Total Rooms: " + rooms.Count);
            }
            static void RegisterNewGuest(List<Guest> guests)
            {
                Console.Write("Enter Guest Name: ");
                string guestName = Console.ReadLine();

                Console.Write("Enter Check In Date: ");
                string checkInDate = Console.ReadLine();

                Console.Write("Enter Total Nights: ");
                int totalNights = Convert.ToInt32(Console.ReadLine());

                if (totalNights <= 0)
                {
                    Console.WriteLine("Total nights must be greater than zero.");
                    return;
                }

                string guestId = "G" + (guests.Count + 1).ToString("000");

                Guest guest = new Guest
                {
                    GuestId = guestId,
                    GuestName = guestName,
                    CheckInDate = checkInDate,
                    TotalNights = totalNights,
                    RoomNumber = "Not Assigned"
                };

                guests.Add(guest);

                Console.WriteLine("Guest Registered Successfully");
                Console.WriteLine("Guest ID: " + guest.GuestId);
                Console.WriteLine("Guest Name: " + guest.GuestName);
            }
            static void BookRoomForGuest(List<Guest> guests, List<Room> rooms)
            {
                Console.Write("Enter Guest ID: ");
                string guestId = Console.ReadLine();

                Console.Write("Enter Room Number: ");
                int roomNumber = Convert.ToInt32(Console.ReadLine());

                Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);
                Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

                if (guest == null)
                {
                    Console.WriteLine("Guest not found.");
                    return;
                }

                if (room == null)
                {
                    Console.WriteLine("Room not found.");
                    return;
                }

                if (!room.IsAvailable)
                {
                    Console.WriteLine("Room is already booked.");
                    return;
                }

                guest.RoomNumber = room.RoomNumber.ToString();
                room.IsAvailable = false;

                double totalCost = guest.CalculateTotalCost(room.PricePerNight);

                Console.WriteLine("Booking Successful");
                Console.WriteLine("Guest Name: " + guest.GuestName);
                Console.WriteLine("Room Number: " + room.RoomNumber);
                Console.WriteLine("Room Type: " + room.RoomType);
                Console.WriteLine("Price Per Night: " + room.PricePerNight);
                Console.WriteLine("Total Nights: " + guest.TotalNights);
                Console.WriteLine("Total Cost: " + totalCost);
            }
            static void ViewAllRooms(List<Room> rooms)
            {
                if (rooms.Count == 0)
                {
                    Console.WriteLine("No rooms have been added yet.");
                    return;
                }

                Console.WriteLine("Total Rooms: " + rooms.Count);

                var sortedRooms = rooms.OrderBy(r => r.RoomNumber);

                foreach (var room in sortedRooms)
                {
                    Console.WriteLine("Room Number: " + room.RoomNumber);
                    Console.WriteLine("Room Type: " + room.RoomType);
                    Console.WriteLine("Price Per Night: " + room.PricePerNight);

                    if (room.IsAvailable)
                    {
                        Console.WriteLine("Status: Available");
                    }
                    else
                    {
                        Console.WriteLine("Status: Booked");
                    }

                    Console.WriteLine("------------------");
                }
            }
            static void ViewAllGuests(List<Guest> guests)
            {
                if (guests.Count == 0)
                {
                    Console.WriteLine("No guests have been registered yet.");
                    return;
                }

                Console.WriteLine("Total Guests: " + guests.Count);

                var sortedGuests = guests.OrderBy(g => g.GuestName);

                foreach (var guest in sortedGuests)
                {
                    Console.WriteLine("Guest ID: " + guest.GuestId);
                    Console.WriteLine("Guest Name: " + guest.GuestName);
                    Console.WriteLine("Room Number: " + guest.RoomNumber);
                    Console.WriteLine("Check In Date: " + guest.CheckInDate);
                    Console.WriteLine("Total Nights: " + guest.TotalNights);

                    Console.WriteLine("------------------");
                }
            }
        }

    }
    }

