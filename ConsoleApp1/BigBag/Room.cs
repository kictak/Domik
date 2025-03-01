namespace ConsoleApp1.bag
{
    internal class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public required string RoomType { get; set; }
        public required int Coast { get; set; }
        public int AvailableSeats { get; set; }
        public int TotalSeats { get; set; }

    }
}
