using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExcellentAcademy
{
    public class FormForDatabase
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Emergency { get; set; }
        public string Email { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? PaymentDay { get; set; }
    }
}