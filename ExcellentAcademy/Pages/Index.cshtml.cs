using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ExcellentAcademy.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPostSubmit(Form form)
        {
            return RedirectToPage("./Success");
        }

    }
}