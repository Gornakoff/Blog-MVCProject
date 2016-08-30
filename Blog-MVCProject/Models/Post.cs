using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_MVCProject.Models
{
    public class Post
    {
        //public Post()
        //{
        //    this.Date = DateTime.Now;
        //}

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        
        public DateTime? Date { get; set; }
        
        public DateTime? DateModified { get; set; }

        public ApplicationUser Author { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}