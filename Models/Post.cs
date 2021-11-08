﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using TheBlogProject.Enums;

namespace TheBlogProject.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string AuthorId { get; set; }

        [Required]
        [StringLength(75, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
        public string Abstract { get; set; }

        [Required]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime Created { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime? Updated { get; set; }

        public ReadyStatus ReadyStatus { get; set; }
        public string Slug { get; set; }
        public byte[] ImageData { get; set; }
        public string ContentType { get; set; }
        public IFormFile Image { get; set; }

        //navigation property
        public virtual Blog Blog { get; set; }
        public virtual BlogUser Author { get; set; }
        public ICollection<Tag> Tags { get; set; } = new HashSet<Tag>();
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
 