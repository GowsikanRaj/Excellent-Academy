using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace ExcellentAcademy.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        private ExcellentAcademyContext _excellentAcademyContext;

        public IndexModel (ExcellentAcademyContext excellentAcademyContext)
        {
            _excellentAcademyContext = excellentAcademyContext;
        }

        public IActionResult OnPostSubmit(Form form)
        {
            _excellentAcademyContext.Add(form);

            return RedirectToPage("./Success");
        }
    }
}
