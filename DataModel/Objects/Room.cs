using DataModel.Directories;

namespace DataModel.Object
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public RoomType RoomType { get; set; }
        public required int DayPrice { get; set; }
        public ICollection<Stuff> Stuffs { get; set; } = new List<Stuff>();
        public ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();
    }
}
