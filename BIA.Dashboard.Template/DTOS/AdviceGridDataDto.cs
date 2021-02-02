using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.DTOS
{
    public class AdviceGridDataDto
    {
        public string AdviceNumber { get;   set; }
        public DateTime Date { get;   set; }
        public string ICNumber { get;   set; }
        public string Name { get;   set; }
        public string Remarks { get;   set; }
        public int PayrollAdviceId { get;   set; }
        public string Status { get;  set; }
        public decimal? Earning { get; set; }
        public decimal? Deduction { get; set; }
        public string FormattedDate { get; set; }
        public string Action { get;  set; }
    }
}
