using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeeProdicts.Models
{
    public class OrdersItems
    {
        [Key]
        public int ID { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string ItemID { get; set; }
        
        [ForeignKey("Color")]
        public Color Color { get; set; }
        [ForeignKey("Size")]
        public Size Size { get; set; }

        [ForeignKey("Finish")]
        public Finish Finish { get; set; }

        [ForeignKey("Orders")]
        public Orders OrderID { get; set; }
    }
}
