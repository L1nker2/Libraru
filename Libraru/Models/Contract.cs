namespace Libraru.Models
{
    internal class Contract
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
