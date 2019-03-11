using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesVizyoneks2.ViewModels;

namespace RazorPagesVizyoneks2.Pages
{
    public class IndexModel : PageModel
    {
        //UI dan okuyacağımız prop public olmak zorundadır
        public string Title { get; set; }
        public HomeViewModel HomeVM { get; set; } = new HomeViewModel();

        //HTTPGET
        public void OnGet()
        {
            HomeVM.Title = "Home";
            HomeVM.Content = "Test";
            HomeVM.Categories = new List<CategoryDTO>
            {
                new CategoryDTO
                {
                    Id=1,
                    Name="kategori1"
                },
                    new CategoryDTO
                {
                    Id=2,
                    Name="kategori2"
                }
            };
            HomeVM.Product = new ProductDTO { Id = 1, Name = "Kazak" };

            Title = "Anasayfa";

        }

       
        //formdan veri girişi için
        public void OnPost()
        {
            //db operation
        }

    }
}