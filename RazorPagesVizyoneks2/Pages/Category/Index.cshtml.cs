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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesVizyoneks2.Models.NorthwindContext _context;

        public IndexModel(RazorPagesVizyoneks2.Models.NorthwindContext context)
        {
            _context = context;
        }

        public IList<Categories> Categories { get;set; }

        public async Task OnGetAsync()
        {
            Categories = await _context.Categories.ToListAsync();
        }
    }
}
