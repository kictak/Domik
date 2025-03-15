using ConsoleApp1.bag;
using ConsoleApp1.Small;
using ConsoleApp1.Smallbag;

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
                Adress = "Pushino 36,kv 30",
                DateOfBirth = new DateOnly (2201,01,01),
                DocumentNumber = "7777",
                RoomNumber = 42,                
            };

            var gender = new Gender()
            {
                Name = "male"
            };

            var room = new Room()
            {
                DayPrice = 10234
            };

            var roomtype = new RoomType()
            {
                Type = "Luxe",
                Places = 2
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

            MyDbContext context = new MyDbContext();


            /*context.Guests.Add(new Guest() //добавление нового гостя

            {
                Name = "Stepan",
                LastName = "Polyakov",
                Gender = "Male",
                DateOfBirth = new DateOnly(2000, 01, 02),
                DocumentType = "Passport",
                DocumentNumber = "31256661",
                RoomNumber = 42,
            });
            */

            context.Stuffs.Add(new Stuff() //добавление нового гостя

            {
                Name = "Stepan",
                LastName = "Polyakov",
                ShiftNumber = 42
            });
        }
    }
}
