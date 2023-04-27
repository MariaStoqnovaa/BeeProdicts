using BeeProdicts.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.CodeDom;

namespace BeeProdicts.Models
{
    public class CreateProductViewModel
    {

        public SelectList Colors { get; set; }
        public SelectList Finishs { get; set; }
        public SelectList Sizes { get; set; }
        public Product product { get; set; }
        public IFormFile Image { get; set; }
        public CreateProductViewModel(SelectList colors, SelectList finishs, SelectList sizes)
        {

            Colors = colors;
            Finishs = finishs;
            Sizes = sizes;
        }

        public CreateProductViewModel()
        {
            
        }
    }
}