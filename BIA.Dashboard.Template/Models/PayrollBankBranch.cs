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
    public class PayrollBank
    {
        [Key]
        public int PayrollBankId { get; set; }

        public string BankCode { get; set; }
        public string BankName { get; set; }
    }

    public class PayrollBankBranch
    {
        [Key]
        public int PayrollBankBranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }

        public int? PayrollBankId { get; set; }
        [ForeignKey("PayrollBankId")]
        public PayrollBank PayrollBank { get; set; }
    }

}
