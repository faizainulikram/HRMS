using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Models
{
    public class EarningPayrollAdvice
    {
        [Key]
        public int PayrollAdviceId { get; set; }

        [Required]
        public int? PersonnelInformationId { get; set; }

        [Display(Name = "Personnel")]
        public PersonnelInformation PersonnelInformation { get; set; }

        [Required]
        [Display(Name = "Advice Number")]
        public string AdviceNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "IC Number")]
        public string ICNumber { get; set; }

        [Display(Name = "Particular")]
        public string Remarks { get; set; }

        [Display(Name = "From")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime TransactionStartDate { get; set; }

        [Display(Name = "Until")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime TransactionEndDate { get; set; }

        public int? PayrollLedgerId { get; set; }
        public PayrollLedger Ledger { get; set; }


        public string Status { get; set; }

        [Display(Name = "Status Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StatusDate { get; set; }

        [Required]
        public decimal? Earning { get; set; }


    }
}
