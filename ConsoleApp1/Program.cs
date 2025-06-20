using Microsoft.EntityFrameworkCore;
using Storage;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyDbContext context = new MyDbContext();
            context.Database.Migrate();
            return;
        }
    }
}

/*
 ===================================  пример заполнения
 * using DataModel.Directories;
using DataModel.Object;
using Storage;

public static class SeedData
{
    public static void Initialize()
    {
        using var context = new MyDbContext();

        // Автозаполнение полов
        if (!context.Genders.Any())
        {
            context.Genders.AddRange(
                new Gender { Name = "Мужской" },
                new Gender { Name = "Женский" }
            );
        }

        // Автозаполнение типов документов
        if (!context.DocumentTypes.Any())
        {
            context.DocumentTypes.AddRange(
                new DocumentType { DocumentName = "Паспорт" },
                new DocumentType { DocumentName = "Водительское удостоверение" }
            );
        }

        // Автозаполнение типов комнат
        if (!context.Set<RoomType>().Any())
        {
            context.Set<RoomType>().AddRange(
                new RoomType { Type = "Стандарт", Places = 2 },
                new RoomType { Type = "Люкс", Places = 4 }
            );
        }

        // Автозаполнение сотрудника
        if (!context.Stuffs.Any())
        {
            context.Stuffs.Add(new Stuff { Name = "Иван", LastName = "Иванов", Age = 30, ShiftNumber = 1 });
        }

        // Автозаполнение комнаты
        if (!context.Rooms.Any())
        {
            context.Rooms.Add(new Room { Number = 101, RoomType = context.Set<RoomType>().First(), DayPrice = 5000 });
        }

        // Автозаполнение гостя
        if (!context.Guests.Any())
        {
            context.Guests.Add(new Guest
            {
                Name = "Петр",
                LastName = "Петров",
                MiddleName = "Сергеевич",
                Adress = "ул. Ленина, 1",
                DateOfBirth = new DateOnly(1990, 1, 1),
                DocumentNumber = "123456",
                Gender = context.Genders.First(),
                DocumentType = context.DocumentTypes.First()
            });
        }

        context.SaveChanges();
    }
}
*/