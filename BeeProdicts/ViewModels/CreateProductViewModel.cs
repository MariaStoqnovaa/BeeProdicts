using BeeProdicts.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.CodeDom;

namespace BeeProdicts.ViewModels
{
    public class CreateProductViewModel
    {

        public SelectList Colors { get; set; }
        public CreateProductViewModel(SelectList colors)
        {

            Colors = colors;

        }
    }
}