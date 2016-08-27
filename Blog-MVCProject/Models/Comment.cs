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

        [Required]
        public int PostID { get; set; }

        public ApplicationUser AuthorID { get; set; }

        [StringLength(100)]
        public string AuthorName { get; set; }

        [Required]
        public DateTime Date { get; set; }

    }
}