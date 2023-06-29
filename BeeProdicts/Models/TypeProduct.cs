using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeeProdicts.Models
{

    public class TypeProduct
    {
        public TypeProduct()
        {

        }
        public TypeProduct(int TypeId, string Name)
        {
            this.TypeId = TypeId;
            this.Name = Name;
        }
        [Key]
        public int? TypeId { get; set; }
        public string Name { get; set; }
    }
}
