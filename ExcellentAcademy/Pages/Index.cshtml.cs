using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ExcellentAcademy.Pages;

namespace ExcellentAcademy.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPostSubmit(Form form, List<Student> student)
        {
            return RedirectToPage("./Success");
        }
    }
}
