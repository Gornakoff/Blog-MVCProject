using System;
using System.ComponentModel.DataAnnotations;

namespace Blog_MVCProject.Models
{
    public class Comment
    {
        public Comment()
        {
            this.Date = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }
        
        public Post Post { get; set; }

        public ApplicationUser Author { get; set; }
        
        [StringLength(100)]
        public string AuthorName { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
    }
}