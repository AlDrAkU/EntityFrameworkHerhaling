using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkHerhaling.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The text field is required.")]
        public required string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        // Foreign key naar de bijbehorende blog
        public int BlogId { get; set; }

    }
}
