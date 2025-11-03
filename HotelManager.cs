using System.Collections.Generic;

public class HotelManager
{    public List<Room> Rooms { get; set; }
    public List<Receptionist> Receptionists { get; set; }


    public HotelManager()
    {
        Rooms = new List<Room>();
        Receptionists = new List<Receptionist>();
    }


    public void ShowAvailableRooms()
    {

        Console.WriteLine("Available Rooms:");

        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].Status == RoomStatus.Available)
            {
                Console.WriteLine("Room " + Rooms[i].RoomNumber);
            }
        }
    }


    public void ShowOccupiedRooms()
    {
        Console.WriteLine("Occupied Rooms:");
        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].Status == RoomStatus.Occupied)
            {
                Console.WriteLine("Room " + Rooms[i].RoomNumber + " - Guest: " + Rooms[i].CurrentGuest.Name);
            }
        }
    }


    public void BookGuest(int roomNumber, string guestName)
    {
        // Loopar genom alla rum 
        for (int i = 0; i < Rooms.Count; i++)
        {
            // Detta kollar om rumsnumret matchar med det vi letar efter 
            if (Rooms[i].RoomNumber == roomNumber)
            {
                // Detta kollar om rummet är tillgängligt
                if (Rooms[i].Status == RoomStatus.Available)
                {
                    // Skapar ny gäst 
                    Guest newGuest = new Guest();
                    newGuest.Name = guestName;
                    // Detta tilldelar gästen rummet 
                    Rooms[i].CurrentGuest = newGuest;
                    // Detta ändrar rummets status till upptaget 
                    Rooms[i].Status = RoomStatus.Occupied;

                    Console.WriteLine("Room " + roomNumber + " booked for " + guestName);
                }
                else
                {
                    Console.WriteLine("Room" + roomNumber + " is not available ");
                }
                return;
            }
        }

        Console.WriteLine("Room " + roomNumber + " does not exist.");
    }

    public void Checkout(int roomNumber)
    {
        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].RoomNumber == roomNumber)
            {
                if (Rooms[i].Status == RoomStatus.Occupied)
                {
                    Rooms[i].CurrentGuest = null;
                    Rooms[i].Status = RoomStatus.Available;
                    Console.WriteLine("Room " + roomNumber + " is now available.");
                }
                else
                {
                    Console.WriteLine("Room " + roomNumber + "is not occupied.");
                }
                return;
            }
        }
        Console.Writeline("Room " + roomNumber + " does not exist"); 
    }
    
}