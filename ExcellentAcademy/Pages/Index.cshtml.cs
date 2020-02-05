using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExcellentAcademy.Pages
{
    public class IndexModel : PageModel
    {
        private ExcellentAcademyContext _excellentAcademyContext;
        public IndexModel(ExcellentAcademyContext excellentAcademyContext)
        {
            _excellentAcademyContext = excellentAcademyContext;
        }
        public IEnumerable<Days> Days {get; set;}
        public IEnumerable<Subjects> Subjects { get; set; }

        public async Task OnGetAsync() 
        {
            Days = await _excellentAcademyContext.Days.ToListAsync();
            Subjects = await _excellentAcademyContext.Subjects.ToListAsync();
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
                Email = form.email,
                Fees = form.fees
            };
            _excellentAcademyContext.Add(Forms);

            foreach (student s in form.students)
            {
                students = new Students();
                students.FirstName = s.Firstname;
                students.LastName = s.Lastname;
                students.Grade = s.Grade;
                students.StartTime = Convert.ToDateTime(s.Starttime);
                students.EndTime = Convert.ToDateTime(s.Endtime);
                if (s.Subject.Length > 0)
                {
                    foreach (var subject in s.Subject)
                    {
                        students.Subjects += subject + ",";
                    }
                    students.Subjects = students.Subjects.Substring(0, students.Subjects.Length - 1);
                }
                if (s.Days.Length > 0)
                {
                    foreach (var day in s.Days)
                    {
                        students.Days += day + ",";
                    }
                    students.Days = students.Days.Substring(0, students.Days.Length - 1);
                }
                
                _excellentAcademyContext.Add(students);
            }

            _excellentAcademyContext.SaveChanges();

            return RedirectToPage("./Success");
        }

    }
}
