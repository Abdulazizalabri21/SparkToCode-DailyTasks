using Microsoft.Win32;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Hotel_Management_System
{
    // Room Class
    public class Room
    {

        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }


        public Room(int roomNumber, string roomType, decimal pricePerNight, bool isAvailable)

        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;


        }

      public void displayRooms() 
        {
            if (IsAvailable)
            {
                Console.WriteLine(RoomNumber);
                Console.WriteLine(RoomType);
                Console.WriteLine(PricePerNight);
            }
            else 
            { 
                Console.WriteLine("Sorry all the rooms are reserved ");
            }

        }


    }
    // Guest class 
    public class Guest 
    {

        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public int TotalNights { get; set; }

        // rate per night, used for cost calculation only 
        private const double RatePerNight = 100.000;

        // Constructor
        public Guest (string guestId, string guestName, string roomNumber, DateTime checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            RoomNumber = roomNumber;
            CheckInDate = checkInDate;
            TotalNights = totalNights;
        }

        // Methods
        public void DisplayGuest()
        {
            Console.WriteLine("----- Guest Details -----");
            Console.WriteLine("Guest ID     : "+GuestId);
            Console.WriteLine("Guest Name   : "+GuestName);
            Console.WriteLine("Room Number  : "+RoomNumber);
            Console.WriteLine("Check-In Date: "+CheckInDate +":yyyy-MM-dd");
            Console.WriteLine("Total Nights : "+TotalNights);
            Console.WriteLine("Total Cost   : " + CalculateTotalCost(RatePerNight));
        }

        public double CalculateTotalCost(double pricePerNight)
        {
            return RatePerNight * TotalNights;
        }



    } 


    internal class Program
    {
           static  List<Room> rooms = new List<Room>();
           static List<Guest> guests = new List<Guest>();
        static void PreloadRooms() 
        {
            rooms.Add(new Room(101, "Single", 80, true));
            rooms.Add(new Room(102, "Single", 80, true));
            rooms.Add(new Room(103, "Double", 120, true));
            rooms.Add(new Room(104, "Double", 120, true));
            rooms.Add(new Room(104, "Suite", 220, true));
            rooms.Add(new Room(104, "Suite", 220, true));
        } //--> Function to preloadRooms

        static void ShowingMenu()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("      GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
            Console.WriteLine("================================================");
            Console.WriteLine(" 1. Add New Room");
            Console.WriteLine(" 2. Register New Guest");
            Console.WriteLine(" 3. Book a Room for a Guest");
            Console.WriteLine(" 4. View All Rooms");
            Console.WriteLine(" 5. View All Guests");
            Console.WriteLine(" 6. Search & Filter Rooms");
            Console.WriteLine(" 7. Guest & Booking Statistics");
            Console.WriteLine(" 8. Update Room Price");
            Console.WriteLine(" 9. Guest Lookup by Name");
            Console.WriteLine("10. Room Type Breakdown Report");
            Console.WriteLine("11. Check Out a Guest");
            Console.WriteLine("12. Remove Unavailable Rooms");
            Console.WriteLine("13. Extend Guest Stay");
            Console.WriteLine("14. Highest Revenue Booking");
            Console.WriteLine("15. Guest Pagination Viewer");
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("================================================");
        } //-- only to show the menu, makes the code more organized 


        static void AddNewRoom()
        {
            Console.WriteLine("\n----- Add New Room -----");

            // entring room number (must be a positive number)
            Console.Write("Enter room number: ");
            string roomNumberInput = Console.ReadLine();

            if (!int.TryParse(roomNumberInput, out int roomNumberValue) || roomNumberValue <= 0)
            {
                Console.WriteLine("Error: Room number must be a positive number.");
                return;
            }


            // Check for duplicate room number using LINQ Any()
            bool roomExists = rooms.Any(r => r.RoomNumber == roomNumberValue);
            if (roomExists)
            {
                Console.WriteLine("Error: Room " + roomNumberValue + " already exist, Cannot add duplicate");
                return;
            }

            // room type
            Console.Write("Enter room type (Single / Double / Suite): ");
            string roomType = Console.ReadLine();

            if (roomType != "Single" && roomType != "Double" && roomType != "Suite")
            {
                Console.WriteLine("Error: Room type must be Single, Double, or Suite");
                return;
            }

            // entring the price per night (must be a positive number)
            Console.Write("Enter price per night: ");
            string priceInput = Console.ReadLine();

            if (!decimal.TryParse(priceInput, out decimal pricePerNight) || pricePerNight <= 0)
            {
                Console.WriteLine("Error: Price per night must be a positive number");
                return;
            }

            // Create new Room and add to list called (rooms)
            Room newRoom = new Room(roomNumberValue, roomType, pricePerNight, true);
            rooms.Add(newRoom);

            // Success message 
            Console.WriteLine("\nRoom added successfully!");
            Console.WriteLine($"Room Number   :" + newRoom.RoomNumber);
            Console.WriteLine($"Room Type     :" + newRoom.RoomType);
            Console.WriteLine($"Price/Night   :" + newRoom.PricePerNight);
            Console.WriteLine($"Status        : Available");
            Console.WriteLine($"Total Rooms   :" + rooms.Count);
        }

        static void RegisterNewGuest()
        {


            string guestId = "G" + (guests.Count() + 1).ToString("D3");

            Console.WriteLine("Enter the Guest Name: ");
            string guestName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(guestName) || !guestName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) //---> validate the name if there are spicail char or numbers 
            {
                Console.WriteLine("Error: Guest name must contain only letters (no numbers or symbols).");
                return;
            }

            Console.Write("Enter total nights: ");
            if (!int.TryParse(Console.ReadLine(), out int nights) || nights <= 0) //---> validate the nights number >>>>> (>0) 
            {
                Console.WriteLine("Error: Total nights must be a positive number.");
                return;
            }

            Console.Write("Enter check-in date (yyyy-MM-dd): ");
            string dateInput = Console.ReadLine();

            if (!DateTime.TryParse(dateInput, out DateTime checkInDate))//---> validate the date
            {
                Console.WriteLine("Error: Invalid date format. Please use yyyy-MM-dd.");
                return;
            }

            Guest NewGuest = new Guest(guestId, guestName, "Not Assigned", checkInDate, nights);
            guests.Add(NewGuest);

            Console.WriteLine(" The "+ guestId + " added successfully!");
        }




            static void Main(string[] args)
        {



           PreloadRooms();

                bool exit = false;

                while (!exit)
                {

                ShowingMenu();

                    Console.Write("Enter your choice: ");

                    if (!int.TryParse(Console.ReadLine(), out int choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        Console.ReadKey();
                        continue;
                    }

                switch (choice)
                {
                    case 1:
                           AddNewRoom();
                        break;

                    case 2:
                        RegisterNewGuest();
                        break;

                    case 3:
                        // BookRoom(rooms, guests);
                        break;

                    case 4:
                        //ViewAllRooms(rooms);
                        break;

                    case 5:
                        // ViewAllGuests(guests);
                        break;

                    case 6:
                        //SearchAndFilterRooms(rooms);
                        break;

                    case 7:
                        // GuestBookingStatistics(rooms, guests);
                        break;

                    case 8:
                        //UpdateRoomPrice(rooms);
                        break;

                    case 9:
                        // GuestLookupByName(guests);
                        break;

                    case 10:
                        //RoomTypeBreakdownReport(rooms);
                        break;

                    case 11:
                        // CheckOutGuest(rooms, guests);
                        break;

                    case 12:
                        // RemoveUnavailableRooms(rooms);
                        break;

                    case 13:
                        // ExtendGuestStay(guests);
                        break;

                    case 14:
                        //HighestRevenueBooking();
                        break;

                    case 15:
                        // GuestPaginationViewer(guests);
                        break;

                }

                Console.WriteLine("Press any KEY");
                Console.ReadKey();
                Console.Clear();
            }


        }
    }
}
