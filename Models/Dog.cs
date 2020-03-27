namespace WufWalker.Models
{
    // C# representation of the dogs table
    public class Dogs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public string Breed { get; set; }
        public string Notes { get; set; }
    }
}
