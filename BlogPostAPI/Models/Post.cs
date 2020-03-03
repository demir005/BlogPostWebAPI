using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPostAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string  Description { get; set; }
        public string Body { get; set; }

        [NotMapped]
        public List<string> tagList { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
