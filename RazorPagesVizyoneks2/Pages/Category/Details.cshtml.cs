using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesVizyoneks2.Models;

namespace RazorPagesVizyoneks2.Pages.Category
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesVizyoneks2.Models.NorthwindContext _context;

        public DetailsModel(RazorPagesVizyoneks2.Models.NorthwindContext context)
        {
            _context = context;
        }

        public Categories Categories { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Categories = await _context.Categories.FirstOrDefaultAsync(m => m.CategoryId == id);

            if (Categories == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
