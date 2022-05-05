using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class DiscussionBoard
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string DiscussionName { get; set; }

        [Required]
        public string DiscussionContent { get; set; }

        public string Date { get; set; }
    }
}
