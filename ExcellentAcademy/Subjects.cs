using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExcellentAcademy
{
    public class Subjects
    {
        [Key]
        public long SubjectId { get; set; }
        public string SubjectName { get; set; }
    }
}
