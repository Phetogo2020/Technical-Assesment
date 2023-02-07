using System.ComponentModel.DataAnnotations;

namespace SimpleApp.Service.Models
{
    public class Comment
    {
        [Key]
        public int CommentsId { get; set; }
        public string Comments { get; set; }
    }
}
