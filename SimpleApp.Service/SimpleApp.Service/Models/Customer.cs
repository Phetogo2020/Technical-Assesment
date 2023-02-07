using System.ComponentModel.DataAnnotations;

namespace SimpleApp.Service.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public Comment Comment { get; set; }

    }
}
