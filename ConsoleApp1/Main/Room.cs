using ConsoleApp1.Smallbag;

namespace ConsoleApp1.bag
{
    internal class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public required RoomType RoomType { get; set; }
        public required int DayPrice { get; set; }
        public ICollection<Stuff> Stuffs { get; set; } = new List<Stuff>();
        public ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();
    }
}
