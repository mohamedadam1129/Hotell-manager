A console-based hotel management system built in C# that allows receptionists to manage room reservations, guest check-ins/check-outs, and room availabilty. 

=== Features ====

1. User Authentication : Secure login system for receptionists

2. Room management;
   - View all available rooms
   - View all occupied rooms with guest information
   - Book guests into available rooms
   - Check out guests from occupied rooms
   - Mark rooms as temporarily unavailble
   - Automatic save and load functionality using text files
   - Menu- Driven Interface
  

== Getting Started == 

1. Installation (clone or dowload the project files)
2. Create a neew .NET console application (If starting fresh)
3. Add all the .cs files to the project folder (Guest.cs, Room.cs, RoomStatus.cs, Receptionist.cs, HotelManager.cs, Program.cs)
4. Running the program
   - Navigate to the project directory. When cloning project you might land in a directory called Hotell-manager
   - Change the directory to HotelReservationSystem. That is where the application lies and you can then go with 
   - Dotnet run
   - On the first run, the program will create default data: Rooms: 101,102(occupied by John Doe9, 103, 105
   - The deafult Login is username: Receptionist1 & password: password
   - The program flow looks like this: 
     - Start the program
     - Enter your username
     - Enter your password
     - If credentials are correct, you will acces the main menu 
