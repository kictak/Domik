namespace DataModel.Directories
{
    public class RoomType
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public int Places { get; set; }

        public string Description
        {
            get
            {
                return $"{Type} ({Places} мест)";
            }
        }
    }
}