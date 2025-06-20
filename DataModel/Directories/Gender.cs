namespace DataModel.Directories
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Guest> Guest { get; set; } = new List<Guest>();
    }
}