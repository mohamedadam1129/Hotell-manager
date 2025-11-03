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
}