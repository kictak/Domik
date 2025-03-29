namespace DataModel.Directories
{
    public class RoomType
    {
        public int Id {  get; set; }

        public required string Type { get; set; }

        public required int Places { get; set; }
    }
}
