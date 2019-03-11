using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesVizyoneks2.Pages
{
    public class DetailModel : PageModel
    {
        public string RequestId { get; set; }

        public void OnGet(int? id,string name)
        {
            RequestId = id.ToString() ?? "NULL";
        }
    }
}