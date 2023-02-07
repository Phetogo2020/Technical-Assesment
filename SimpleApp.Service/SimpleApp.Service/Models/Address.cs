using System.ComponentModel.DataAnnotations;

namespace SimpleApp.Service.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string PAddress1 { get; set; }
        public string PAddress2 { get; set; }
        public string PAddress3 { get; set; }
        public string PAddress4 { get; set; }
    }
}
