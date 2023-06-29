using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeeProdicts.Models
{
    public class HoneyProductViewModel
    {
        public SelectList Colors { get; set; }
        public SelectList Finishs { get; set; }
        public SelectList Sizes { get; set; }
        public SelectList Type { get; set; }
        public Product product { get; set; }
        public IFormFile Image { get; set; }

        public HoneyProductViewModel(SelectList colors, SelectList finishs, SelectList sizes, SelectList types)
        {

            Colors = colors;
            Finishs = finishs;
            Sizes = sizes;
            Type = types;
        }

        public HoneyProductViewModel()
        {

        }
    }
}
