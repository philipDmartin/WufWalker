namespace WufWalker.Models
{
    // C# representation of the walks table
    public class Walks
    {
        public int Id { get; set; }
        public double Date { get; set; }
        public string Address { get; set; }
        public int Duration { get; set; }
        public int WalkerId { get; set; }
        public int DogId { get; set; }
    }
}
