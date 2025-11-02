using System.Collections.Generic;

public class HotelManager
{    public List<Room> Rooms { get; set; }
    public List<Receptionist> Receptionists { get; set; }


    public HotelManager()
    {
        Rooms = new List<Room>();
        Receptionists = new List<Receptionist>(); 
    }
}