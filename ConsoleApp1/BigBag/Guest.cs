using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.bag
{
    internal class Guest
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public required string Gender { get; set; }
        public string? Adress { get; set; }
        public required DateOnly DateOfBirth { get; set; }
        public required string DocumentType { get; set; }
        public required string DocumentNumber { get; set; }
        public required int RoomNumber { get; set; }
    }
}
