using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesVizyoneks2.InputModels
{
    public class ProductInputModel
    {
        [Required(ErrorMessage ="Name Boş Geçilemez")]
        public string Name { get; set; }

       [Range(0,100, ErrorMessage ="Max 100 min 0")]
        public decimal Price { get; set; }

        public int Stock { get; set; }

    }

}
