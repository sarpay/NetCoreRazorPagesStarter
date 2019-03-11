using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesVizyoneks2.InputModels;

namespace RazorPagesVizyoneks2.Pages
{
    public class ProductAddModel : PageModel
    {
        //Input Modeller bindProperty ile Model Binding yapıyoruz
        [BindProperty]
        public ProductInputModel InputModel { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return Page();
        }


        public IActionResult OnPostCreate()
        {
            if (ModelState.IsValid)
            {
                return Page();
                //db operation
            }

            return RedirectToPage("Index");


        }


    }
}