using DataModel.Object;

namespace DataModel.Directories
{
    public class CheckIn
    {
        public int Id { get; set; }
        public DateOnly Enter { get; set; }
        public DateOnly Exit { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }

        // Навигационное свойство для гостей
        public Guest Guest { get; set; }

        public Room Room { get; set; }
    }
}