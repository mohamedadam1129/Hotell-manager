using System.Net;

class Program
{
    static void Main(string[] args)
    {
        HotelManager hotelManager = new HotelManager();

        // Lägger till rum för att testa
        Room room101 = new Room();
        room101.RoomNumber = 101;
        room101.Status = RoomStatus.Available;
        room101.CurrentGuest = null;
        hotelManager.Rooms.Add(room101);

        // lägger till room 102 med en guest
        Room room102 = new Room();
        room102.RoomNumber = 102;
        room102.Status = RoomStatus.Occupied;
        Guest guest1 = new Guest();
        guest1.Name = "John doe";
        room102.CurrentGuest = guest1;
        hotelManager.Rooms.Add(room102);

        // lägger till rom 103
        Room room103 = new Room();
        room103.RoomNumber = 103;
        room103.Status = RoomStatus.Available;
        room103.CurrentGuest = null;
        hotelManager.Rooms.Add(room103);


        Room room105 = new Room();
        room105.RoomNumber = 105;
        room105.Status = RoomStatus.Available;
        room105.CurrentGuest = null;
        hotelManager.Rooms.Add(room105);

        // lägger till receptionist
        Receptionist receptionist = new Receptionist();
        receptionist.Username = "admin";
        receptionist.Password = "password";
        hotelManager.Receptionists.Add(receptionist);

        Console.WriteLine("Hotel system Initialized!");
 
        bool isLoggedIn = Login(hotelManager);

        if (isLoggedIn == false)
        {
            Console.WriteLine("Exiting program....");
            return;
        }

        Console.WriteLine("Welcome to the Hotel management system!");

        bool keepRunning = true; 

        while (keepRunning)
        {
            DisplayMenu();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                hotelManager.ShowAvailableRooms();
            }
            else if (choice == "2")
            {
                hotelManager.ShowOccupiedRooms();
            }
            else if (choice == "3")
            {
                Console.Write("Enter room number to book: ");
                string roomInput = Console.ReadLine();
                int roomNumber = int.Parse(roomInput);

                Console.Write("Enter guest name: ");
                string guestName = Console.ReadLine();

                hotelManager.BookGuest(roomNumber, guestName); 
            }
            else if (choice == "4")
            {
                Console.Write("Enter room number to check out: ");
                string roomInput = Console.ReadLine();
                int roomNumber = int.Parse(roomInput);

                hotelManager.Checkout(roomNumber); 
            }
            else if (choice == "5")
            {
                Console.Write("Enter room number to mark as unavailable:");
                int roomNumber = int.Parse(Console.ReadLine());
                hotelManager.MarkRoomUnavailable(roomNumber); 
            }
            else if (choice == "6")
            {
                Console.WriteLine("Exiting program.... Goodbye!");
                keepRunning = false; 
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    static bool Login(HotelManager manager)
    {
        Console.WriteLine("=== Login ===");

        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();


        foreach (var receptionist in manager.Receptionists)
        {
            if (receptionist.Username == username && receptionist.Password == password)
            {
                Console.WriteLine("Login successful!");
                return true;
            }

        }

        Console.WriteLine("Login failed! Invalid username or password. ");
        return false;
    }
    
    static void DisplayMenu()
    {
        Console.WriteLine(); 
        Console.WriteLine("=== Hotel Management System === ");
        Console.WriteLine("1. View Available Rooms");
        Console.WriteLine("2. View Occupied Rooms");
        Console.WriteLine("3. Book a Guest");
        Console.WriteLine("4. Check-out a Guest");
        Console.WriteLine("5. Mark Room as Unavailable: ");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: "); 
    }
}