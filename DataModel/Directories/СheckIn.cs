namespace DataModel.Directories
{
    public class CheckIn
    {
        public int Id {  get; set; }
        public DateOnly Enter {  get; set; }
        public DateOnly Exit { get; set; }
        public int GuestId { get; set; }
        // Навигационное свойство для группы
        public required Guest Guest { get; set; }
    }
}
