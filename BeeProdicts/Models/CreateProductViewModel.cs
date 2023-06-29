using Microsoft.AspNetCore.Mvc.Rendering;
using System.CodeDom;

namespace BeeProdicts.Models
{
    public class CreateProductViewModel
    {
        public SelectList Colors { get; set; }
        public SelectList Finishs { get; set; }
        public SelectList Sizes { get; set; }
        public SelectList Type { get; set; }
        public Product product { get; set; }
        public IFormFile Image { get; set; }

        public CreateProductViewModel(SelectList colors, SelectList finishs, SelectList sizes, SelectList types)
        {

            Colors = colors;
            Finishs = finishs;
            Sizes = sizes;
            Type = types;
        }

        public CreateProductViewModel()
        {

        }
    }
}