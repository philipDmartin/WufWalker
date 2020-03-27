namespace WufWalker.Models
{
    // C# representation of the owners table
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int NeighborhoodId { get; set; }
        public string Phone { get; set; }
    }
}
