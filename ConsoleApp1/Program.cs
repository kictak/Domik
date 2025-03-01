using ConsoleApp1.bag;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guest = new Guest()
            {
                Name = "Stepan",
                LastName = "Tramp",
                Gender = "Male",
                Adress = "Pushino 36,kv 30",
                DateOfBirth = new DateOnly (2201,01,01),
                DocumentNumber = "7777",
                DocumentType = "passport",
                RoomNumber = 42,                
            };

            var room = new Room()
            {
                RoomType = "Luxe",
                Coast = 10234
            };

            var stuff = new Stuff() 
            {
                Name = "Svetlana",
                LastName = "Karapuzova",
                ShiftNumber = 2
            };


            //var name= guest?.Name?.ToArray();

            if(guest.Name != null)
            {
                Console.WriteLine(guest.Name.Length);
            }

            Console.WriteLine((guest.Name??"").Length);

            var length = guest.Name?.Length ?? 0;


        }
    }
}
