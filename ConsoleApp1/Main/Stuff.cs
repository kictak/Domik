
namespace ConsoleApp1.bag
{
    internal class Stuff
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public string ? MiddleName { get; set; }
        public required int ShiftNumber { get; set; }
        // Навигационное свойство для сотрудники
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
