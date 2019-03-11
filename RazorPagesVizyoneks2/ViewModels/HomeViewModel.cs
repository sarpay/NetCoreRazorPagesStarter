using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesVizyoneks2.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public ProductDTO Product { get; set; }
        public List<CategoryDTO> Categories { get; set; }


    }
}
