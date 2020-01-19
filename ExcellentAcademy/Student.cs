using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExcellentAcademy
{
    public class Students
    {
        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }
        public string Subject { get; set; }
        public string Days { get; set; }
        public int Fees { get; set; }

    }
}
