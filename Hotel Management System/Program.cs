using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

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

        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public int TotalNights { get; set; }

        // rate per night, used for cost calculation only 
        private const double RatePerNight = 100.000;

        // Constructor
        public Guest (int guestId, string guestName, string roomNumber, DateTime checkInDate, int totalNights)
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
                        //AddNewRoom();
                        break;

                    case 2:
                        //RegisterNewGuest(guests);
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
