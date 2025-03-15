using ConsoleApp1.Small;
using ConsoleApp1.Smallbag;

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
        public required string DocumentNumber { get; set; }
        public required int RoomNumber { get; set; }

    }
}
