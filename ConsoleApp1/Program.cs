using DataModel.Directories;
using DataModel.Object;
using Microsoft.EntityFrameworkCore;
using Storage;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDbContext context = new MyDbContext();
            context.Database.Migrate();
            return;

            //var documentTYPE = new DocumentType()
            //{
            //    DocumentName = "tst"
            //};
            //var guest = new Guest()
            //{
            //    Name = "Stepan",
            //    LastName = "Tramp",
            //    GenderId = 1,
            //    Adress = "Pushino 36,kv 30",
            //    DateOfBirth = new DateOnly(2201, 01, 01),
            //    DocumentNumber = "7777",
            //    DocumentType = documentTYPE,
            //};


            //context.Guests.Add(guest);

            //var roomtype = new RoomType()
            //{
            //    Type = "Luxe",
            //    Places = 2
            //};

            //var stuff = new Stuff()
            //{
            //    Name = "Svetlana",
            //    LastName = "Karapuzova",
            //    ShiftNumber = 2
            //};

            //context.Rooms.Add(new Room() //добавление нового гостя
            //{
            //    Number = 42,
            //    RoomType = roomtype,
            //    DayPrice = 100
            //});
            //context.Stuffs.Add(stuff);

            
            ////context.Guests.Add(guest);

            //context.SaveChanges();

            //using (var DbContext = new MyDbContext())
            //{
            //    var genderCount = DbContext.Genders.Count();
            //    var newGender = DbContext.Genders.FirstOrDefault();
            //    if (genderCount == 0)
            //    {
            //        context.Genders.Add(new Gender() //добавление нового гендера
            //        {
            //            Name = "male",
            //        });
            //        context.Genders.Add(new Gender() //добавление нового гендера
            //        {
            //            Name = "feemale",
            //        });
            //        context.SaveChanges();
            //        Console.WriteLine("Gender group has been updated.");
            //    }
            //}
        }
    }
}
