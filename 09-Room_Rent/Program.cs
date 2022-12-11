using System;
using System.Globalization;

namespace RoomRent {
    class Program{
        static void Main (){

            System.Console.WriteLine("");
            System.Console.WriteLine("How many room will by rent? 0/9");
            System.Console.Write("type: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0){ n = 0; }else if (n > 10){ n = 10; }
            
            Room[] rooms = new Room[10];

            for (int i=0; i < n; i++){
                System.Console.WriteLine("");
                System.Console.WriteLine("Rent #"+(i+1));

                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                
                System.Console.Write("Email: ");
                string email = Console.ReadLine();

                System.Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                rooms[room] = new Room { Name = name, Email = email, RoomId = room };

            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Busy rooms:");
            for (int i=0; i < 10; i++){
                if (rooms[i] != null){
                    System.Console.WriteLine((i) +": "+ rooms[i].Name +", "+ rooms[i].Email);
                }
            }

            System.Console.WriteLine("");
            Console.ReadKey ();

        }
    }
}
