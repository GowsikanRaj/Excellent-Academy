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

        public Students students { get; set; }
        public FormForDatabase Forms { get; set; }
        public IActionResult OnPostSubmit(Form form)
        {
            Forms = new FormForDatabase
            {
                Address = form.address,
                FirstName = form.firstname,
                LastName = form.lastname,
                Cell = form.cell,
                City = form.city,
                Emergency = form.emergency,
                Phone = form.phone,
                PaymentDay = Convert.ToDateTime(form.paymentday),
                StartingDate = Convert.ToDateTime(form.startingdate),
                Email = form.email
            };
            _excellentAcademyContext.Add(Forms);

            students = new Students();

            foreach (student s in form.students)
            {
                students.FirstName = s.Firstname;
                students.LastName = s.Lastname;
                students.Grade = s.Grade;
                students.Subjects = s.Subject;
                students.Days = s.Days;
                students.Fees = form.fees;
                _excellentAcademyContext.Add(students);
            }

            _excellentAcademyContext.SaveChanges();

            return RedirectToPage("./Success");
        }

    }
}
