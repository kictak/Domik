using ConsoleApp1.bag;

namespace ConsoleApp1.Smallbag
{
    internal class DocumentType
    {
        public int Id { get; set; }
        public required string DocumentName { get; set; }

        public ICollection<Guest> Guest { get; set; } = new List<Guest>();

    }
}
