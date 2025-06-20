using Storage;

namespace ViewModel.RoomViewModel
{
    public class RoomListViewModel
    {
        public List<RoomView> Rooms { get; set; }

        public RoomListViewModel()
        {
            using (var db = new MyDbContext())
            {
                Rooms = db.Rooms
                    .Select(r => new RoomView
                    {
                        Id = r.Id,
                        Number = r.Number,
                        DayPrice = r.DayPrice,
                        RoomType = r.RoomType,
                        Status = r.CheckIns.Any(c => c.Exit == null) ? "Занята" : "Свободна"
                    })
                    .ToList();
            }
        }
    }

    public class RoomView
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Status { get; set; }
        public DataModel.Directories.RoomType RoomType { get; set; }
        public int DayPrice { get; set; }
    }
}