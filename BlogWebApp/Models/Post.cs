using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        
        [MaxLength(256)]
        public string Title { get; set; }

        [MaxLength(2048)]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; } = DateTime.Now;

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public string UserName { get; set; }

        public Post()
        {

        }
    }
}