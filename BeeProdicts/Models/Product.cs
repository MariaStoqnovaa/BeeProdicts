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


        [ForeignKey("SizeID")]
        public int SizeID { get; set; }

        [ForeignKey("ColorID")]
        public int ColorID{get;set;}
        public string Image { get; set; }

    }
}
