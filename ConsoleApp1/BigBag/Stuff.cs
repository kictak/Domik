namespace ConsoleApp1.bag
{
    internal class Stuff
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        //public required string Adress { get; set; }
        public string ? MiddleName { get; set; }
        public required int ShiftNumber { get; set; }
    }
}
