using System.ComponentModel.DataAnnotations;

namespace BeeProdicts.Models
{
    public class Orders
    {

        [Key]
        public int OrderID { get; set; }
        public string UserID { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public string Phone{ get; set; }
        public DateTime Created{ get; set; }
        public DateTime Total{ get; set; }
    }
}
