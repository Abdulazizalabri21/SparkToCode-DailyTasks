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
        private const decimal RatePerNight = 100;

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

        public decimal CalculateTotalCost(decimal RatePerNight)
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
            rooms.Add(new Room(107, "Single", 80, true));
            rooms.Add(new Room(102, "Single", 80, true));
            rooms.Add(new Room(103, "Double", 120, true));
            rooms.Add(new Room(105, "Double", 120, true));
            rooms.Add(new Room(106, "Suite", 220, true));
            rooms.Add(new Room(101, "Suite", 220, true));
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
        //--- Easy cases
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

         static void BookRoom()
    {
        Console.WriteLine("------ Book a Room ------");

        // Prompt for guest ID and room number
        Console.Write("Enter guest ID: ");
        string guestId = Console.ReadLine();

        Console.Write("Enter room number: ");
        int roomNumber = int.Parse(Console.ReadLine());

        
            

        // Use LINQ FirstOrDefault() to find the guest and the room
        Guest selectedGuest = guests.FirstOrDefault(g => g.GuestId == guestId);
        Room selectedRoom = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

        if (selectedGuest == null)
        {
            Console.WriteLine("Error: Guest not found.");
            return;
        }

        if (selectedRoom == null)
        {
            Console.WriteLine("Error: Room not found.");
            return;
        }

        //Check the room is currently available
        if (!selectedRoom.IsAvailable)
        {
            Console.WriteLine("Room is already booked.");
            return;
        }


        //Assign room to guest, mark room as unavailable
        selectedGuest.RoomNumber = selectedRoom.RoomNumber.ToString();
        decimal PricePerN = selectedRoom.PricePerNight;
        selectedRoom.IsAvailable = false;

        //Display booking confirmation
        Console.WriteLine("\nBooking confirmed!");
        Console.WriteLine($"Guest Name    : "+selectedGuest.GuestName);
        Console.WriteLine($"Room Number   : "+ selectedRoom.RoomNumber);
        Console.WriteLine($"Room Type     : "+ selectedRoom.RoomType);
        Console.WriteLine($"Total Nights  : "+selectedGuest.TotalNights); 
        Console.WriteLine($"Price/Night   : "+selectedRoom.PricePerNight+ " OMR"); 
        Console.WriteLine($"Total Cost    : "+selectedGuest.CalculateTotalCost(PricePerN) +" OMR");
           
    }

        static void ViewAllRooms()
        {
            Console.WriteLine("\n----- All Rooms -----");

            //Handle empty list
            if (!rooms.Any())
            {
                Console.WriteLine("No rooms have been added yet.");
                return;
            }

            //total room count using Count()
            Console.WriteLine($"Total Rooms: "+rooms.Count());

            // ordering the list based on room Number ascending

            List <Room> OrderdListOfRooms = rooms.OrderByDescending(o => o.RoomNumber).ToList();
            //var sortedRooms = rooms.OrderBy(r => r.RoomNumber);

            //Project each room into a formatted display line using Select() 


            var roomDetails = OrderdListOfRooms.Select(r => new{ RoomNumber = r.RoomNumber, RoomType = r.RoomType,  PricePerNight = r.PricePerNight,   Status = r.IsAvailable ? "Available" : "Booked" });


            foreach (var room in roomDetails)
            {
                Console.WriteLine($"Room Number : "+room.RoomNumber);
                Console.WriteLine($"Room Type   : "+room.RoomType);
                Console.WriteLine($"Price/Night : "+room.PricePerNight);
                Console.WriteLine($"Status      : "+room.Status);
                Console.WriteLine("\n");
            }
        }

        static void ViewAllGuests()
        {
            // Check if there are any registered guests
            if (guests.Count() == 0)
            {
                Console.WriteLine("No guests have been registered yet.");
                return;
            }

            // Display total number of guests
            Console.WriteLine("Total Guests: " + guests.Count());

            // Sort guests alphabetically by guest name
            List<Guest> guestList = guests.OrderBy(r => r.GuestName).ToList();

            // Display each guest
            foreach (Guest guest in guestList)
            {
                guest.DisplayGuest();
            }
        }
        //--MEDIUM
        static void SearchAndFilterRooms()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Search & Filter Rooms =====");
                Console.WriteLine("1. Show All Available Rooms");
                Console.WriteLine("2. Filter by Room Type");
                Console.WriteLine("3. Filter by Maximum Price");
                Console.WriteLine("4. Room Price Statistics");
                Console.WriteLine("0. Back");

                Console.Write("Enter your choice: ");

                // Validate menu choice

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("You entered invalid input !!");

                }

                switch (choice)
                {
                    case 1:
                        // Retrieve available rooms and sort by price

                        List<Room> availableRooms = rooms.Where(r => r.IsAvailable).OrderBy(r => r.PricePerNight).ToList();


                        // Display number of available rooms
                        Console.WriteLine("Available Rooms: " + availableRooms.Count());

                        if (!availableRooms.Any())
                        {
                            Console.WriteLine("No rooms found for the selected criteria");
                            break;
                        }

                        foreach (Room room in availableRooms)
                        {
                            room.displayRooms();
                        }

                        break;

                    case 2:
                        // Retrieve rooms matching the entered Room type

                        Console.Write("Enter Room Type: ");
                        string roomType = Console.ReadLine();

                        List<Room> roomTypes = rooms.Where(r => r.RoomType.Equals(roomType, StringComparison.OrdinalIgnoreCase)).ToList();

                        Console.WriteLine("Rooms Found: " + roomTypes.Count());

                        if (!roomTypes.Any())
                        {
                            Console.WriteLine("No rooms found for the selected criteria");
                            break;
                        }

                        foreach (Room room in roomTypes)
                        {
                            room.displayRooms();
                        }

                        break;

                    case 3:
                        // Validate maximum price

                        Console.Write("Enter Maximum Price: ");
                        decimal maxPrice = decimal.Parse(Console.ReadLine());
                        // Retrieve available rooms within the price limit

                        List<Room> priceRooms = rooms.Where(r => r.IsAvailable && r.PricePerNight <= maxPrice).OrderBy(r => r.PricePerNight).ToList();

                        // counting the avaliable where <= maxPrice
                        Console.WriteLine("Rooms Found: " + priceRooms.Count());

                        // Check if no rooms were found
                        if (!priceRooms.Any())
                        {
                            Console.WriteLine("No rooms found for the selected criteria");
                            break;
                        }
                        // Display matching rooms

                        foreach (Room room in priceRooms)
                        {
                            room.displayRooms();
                        }

                        break;

                    case 4:

                        if (rooms.Count() == 0)
                        {
                            Console.WriteLine("No rooms have been added yet.");
                            break;
                        }
                        // Display room statistics using LINQ
                        Console.WriteLine("Total Rooms       : " + rooms.Count());
                        Console.WriteLine("Available Rooms   : " + rooms.Count(r => r.IsAvailable));
                        Console.WriteLine("Average Price     : " + rooms.Average(r => r.PricePerNight));
                        Console.WriteLine("Cheapest Price    : " + rooms.Min(r => r.PricePerNight));
                        Console.WriteLine("Highest Price     : " + rooms.Max(r => r.PricePerNight));

                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

            } while (choice != 0);
        }

       
        static void GuestBookingStatistics()
        {
            // Guests with an assigned room
            List<Guest> bookedGuests = guests.Where(g => g.RoomNumber != "Not Assigned").ToList();

            // Total registered guests
            Console.WriteLine("Total Registered Guests : " + guests.Count());

            // Total guests with bookings
            Console.WriteLine("Guests With Booking     : " + bookedGuests.Count());

            // Total rooms
            Console.WriteLine("Total Rooms             : " + rooms.Count());

            // Total booked rooms
            Console.WriteLine("Booked Rooms            : " + rooms.Count(r => !r.IsAvailable));

            // Check if there are active bookings
            if (!bookedGuests.Any())
            {
                Console.WriteLine("No active bookings recorded.");
                return;
            }

            // Average nights
            Console.WriteLine("Average Nights          : "+ bookedGuests.Average(g => g.TotalNights).ToString());

            Console.WriteLine("\n=>>>>>>Top 3 Highest Spending Guests <<<<<=");

            // Top 3 highest spending guests
              List<Guest> topGuests = bookedGuests.OrderByDescending(g =>g.CalculateTotalCost(rooms.First(r => r.RoomNumber.ToString() == g.RoomNumber).PricePerNight)).Take(3).ToList();
            
            foreach (Guest guest in topGuests)
            {
                decimal totalCost = guest.CalculateTotalCost( rooms.First(r => r.RoomNumber.ToString() == guest.RoomNumber).PricePerNight);

                Console.WriteLine(guest.GuestName +" - Room "+ guest.RoomNumber + "-OMR" + totalCost);
            }

            Console.WriteLine("=>>>> Booking Summary <<<<=");

            // Booking summary using Select()


            var summary = bookedGuests.Select(g =>
            {
                Room room = rooms.First(r => r.RoomNumber.ToString() == g.RoomNumber);

                decimal totalCost = g.CalculateTotalCost(room.PricePerNight);

                return g.GuestName + " - Room " + g.RoomNumber + " - " + g.TotalNights + " nights - OMR " + totalCost.ToString();
            });



            foreach (string line in summary)
            {
                Console.WriteLine(line);
            }
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
                           BookRoom();
                        break;

                    case 4:
                         ViewAllRooms();
                        break;

                    case 5:
                        ViewAllGuests();
                        break;

                    case 6:
                        SearchAndFilterRooms();
                        break;

                    case 7:
                        GuestBookingStatistics();
                        break;

                    case 8:
                        //UpdateRoomPrice();
                        break;

                    case 9:
                        // GuestLookupByName();
                        break;

                    case 10:
                        //RoomTypeBreakdownReport();
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
