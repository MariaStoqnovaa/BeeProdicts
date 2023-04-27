using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BeeProdicts.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        [ForeignKey("FinishID")]
        public int FinishID { get; set; }

        public Finish Finish { get; set; }


        [ForeignKey("SizeID")]
        public int SizeID { get; set; }
        public Size Size { get; set; }

        [ForeignKey("ColorID")]
        public int ColorID{get;set;}
        public Color Color { get; set; }
        public string Image { get; set; }

    }
}
