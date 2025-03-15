using ConsoleApp1.bag;

namespace ConsoleApp1.Smallbag
{
    internal class CheckIn
    {
        public int id {  get; set; }
        public DateOnly Enter {  get; set; }
        public DateOnly Exit { get; set; }
        public int GuestId { get; set; }
        // Навигационное свойство для группы
        public required Guest Guest { get; set; }
    }
}
