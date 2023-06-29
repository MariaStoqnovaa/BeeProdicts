using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeeProdicts.Models
{
    public class DetailsViewModel
    {
        public SelectList Colors { get; set; }
        public SelectList Finishs { get; set; }
        public SelectList Sizes { get; set; }

        public Product product { get; set; }
        public DetailsViewModel(SelectList colors, SelectList finishs, SelectList sizes, Product product)
        {

            Colors = colors;
            Finishs = finishs;
            Sizes = sizes;
            this.product = product;
        }

        public DetailsViewModel()
        {

        }
    }
}
