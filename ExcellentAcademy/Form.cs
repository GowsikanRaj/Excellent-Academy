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
        public List<student> students { get; set; }
    }

    public class student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Grade { get; set; }
        public string Subject { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
        public string Days { get; set; }

    }
}