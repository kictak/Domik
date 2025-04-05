namespace DataModel.Directories
{
    public class Guest
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public string? Adress { get; set; }
        public required DateOnly DateOfBirth { get; set; }
        //public int DocumentTypeId { get; set; }
        public required string DocumentNumber { get; set; }

        public ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();
        // Внешний ключ для гнедера 
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        // Навигационное свойство для гендера

        public DocumentType DocumentType{ get; set; }
        public int DocumentTypeId { get; set; }
    }
}
