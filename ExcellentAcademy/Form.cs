using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcellentAcademy
{
    public class Form
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public string emergency { get; set; }
        public string email { get; set; }
        public DateTime startingdate { get; set; }
        
        public DateTime date { get; set; }
        public string signature { get; set; }
        public int fees { get; set; }

        public DateTime paymentday { get; set; }

        public List<student> student { get; set; }

    }

    public class student
    {
        public string Studentname { get; set; }
        public string Grade { get; set; }
        public List<Subject> Subject { get; set; }
        public List<Days> Days { get; set; }
    }

    public class Subject
    {
        public string Math { get; set; }
        public string English { get; set; }
        public string French { get; set; }
        public string Science { get; set; }
    }
    public class Days
    {
        public string Sunday { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
    }
}
