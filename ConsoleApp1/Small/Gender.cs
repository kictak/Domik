using ConsoleApp1.bag;

namespace ConsoleApp1.Small
{
    internal class Gender
    {
        public int Id {  get; set; }
        public required string Name { get; set; }
        //public int GuestId { get; set; }
        // Навигационное свойство для группы
        public ICollection<Guest> Guest { get; set; } = new List<Guest>();
    }
}
