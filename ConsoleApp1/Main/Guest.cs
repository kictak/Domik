using ConsoleApp1.Small;
using ConsoleApp1.Smallbag;
using System.Text.RegularExpressions;

namespace ConsoleApp1.bag
{
    internal class Guest
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        //todo: gender не строка
        public required Gender Gender { get; set; }
        public string? Adress { get; set; }
        public required DateOnly DateOfBirth { get; set; }
        public required DocumentType DocumentType{ get; set; }
        //public int DocumentTypeId { get; set; }
        public required string DocumentNumber { get; set; }
        public required int RoomNumber { get; set; }

        public ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();
        // Внешний ключ для гнедера 
        public int GenderId { get; set; }
        // Навигационное свойство для гендера
        public int DocumentTypeId { get; set; }
    }
}
