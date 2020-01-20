using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExcellentAcademy
{
    public class Days
    {
        [Key]
        public long DayId { get; set; }
        public string DayName { get; set; }
    }
}
