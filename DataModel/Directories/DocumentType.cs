namespace DataModel.Directories;

public class DocumentType
{
    public int Id { get; set; }
    public string DocumentName { get; set; }

    public ICollection<Guest> Guest { get; set; } = new List<Guest>();
}