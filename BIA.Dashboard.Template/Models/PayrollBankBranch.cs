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
    public class PayrollBankBranch
    {
        [Key]
        public int PayrollBankBranchId { get; set; }

        public string Bank { get; set; }
        public string BankName { get; set; }

        public string Branch { get; set; }
        public string BranchName { get; set; }
    }
}
