using System.ComponentModel.DataAnnotations;

namespace BeeProdicts.Models
{
    public class TypeHoneyProduct
    {
        public TypeHoneyProduct()
        {

        }
        public TypeHoneyProduct(int TypeId, string Name)
        {
            this.TypeId = TypeId;
            this.Name = Name;
        }
        [Key]
        public int? TypeId { get; set; }
        public string Name { get; set; }
    }
}
