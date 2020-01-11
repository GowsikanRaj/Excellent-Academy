using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExcellentAcademy.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPostSubmit(Form form)
        {
            foreach (var student in form.student)
            {
                var start = student.Starttime.ToString("h:mm");
                var end = student.Endtime.ToString("h:mm");
            }

            return RedirectToPage("./Success");
        }

    }
}