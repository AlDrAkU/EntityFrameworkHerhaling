namespace EntityFrameworkHerhaling.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigatie-eigenschap om de bijbehorende comments op te halen
        public ICollection<Comment>? Comments { get; set; }
    }
}
