using ConsoleApp1.bag;
using ConsoleApp1.Small;
using ConsoleApp1.Smallbag;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var guest = new Guest()
            //{
            //    Name = "Stepan",
            //    LastName = "Tramp",
            //    GenderId = 1,
            //    Adress = "Pushino 36,kv 30",
            //    DateOfBirth = new DateOnly (2201,01,01),
            //    DocumentNumber = "7777",
            //    RoomNumber = 42,                
            //};

            //var gender = new Gender()
            //{
            //    Nmae = "male"
            //};

            //var room = new Room()
            //{
            //    RoomType = new RoomType("male"),
            //    DayPrice = 10234
            //};

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

            //if(guest.Name != null)
            //{
            //    Console.WriteLine(guest.Name.Length);
            //}

            //Console.WriteLine((guest.Name??"").Length);

            //var length = guest.Name?.Length ?? 0;

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

            using (var DbContext = new MyDbContext())
            {
                var genderCount = DbContext.Genders.Count();
                var newGender = DbContext.Genders.FirstOrDefault();
                if (genderCount == 0)
                {
                    context.Genders.Add(new Gender() //добавление нового гендера
                    {
                        Name = "male",
                    });
                    context.Genders.Add(new Gender() //добавление нового гендера
                    {
                        Name = "feemale",
                    });
                    context.SaveChanges();
                    Console.WriteLine("Gender group has been updated.");
                }
            }
        }
    }
}
