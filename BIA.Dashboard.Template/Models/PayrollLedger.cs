using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BIA.Dashboard.Template.Models.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BIA.Dashboard.Template.Models
{
    public class PayrollLedger
    {
        [Key]
        public int PayrollLedgerId { get; set;}

        //unique
        public string LedgerCode { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string CreatedBy { get; set; }
    }
}
