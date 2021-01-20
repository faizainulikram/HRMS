using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BIA.Dashboard.Template.Models.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BIA.Dashboard.Template.Models
{
    public class PayrollAdvice
    {
        [Flags]
        public enum DDEAList
        {
            BankDetail = 0,
            Salary = 1,
            Earning = 2,
            Deduction = 3,
        }

        [Key]
        public int PayrollAdviceId { get; set; }

        // linked to personnel information
        [Required]
        public int PersonnelInformationId { get; set; }

        [Display(Name = "Personnel")]
        public PersonnelInformation PersonnelInformation { get; set; }

        [Required]
        [Column(TypeName = "char(6)")]
        [Display(Name = "Advice Number")]
        public string AdviceNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        [Display(Name = "IC Number")]
        public string ICNumber { get; set; }

        [Column(TypeName = "char(30)")]
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

        // linked to payroll ledger
        public int? PayrollLedgerId { get; set; }
        public PayrollLedger Ledger { get; set; }

        [Column(TypeName = "char(1)")]
        public string Status { get; set; }

        [Display(Name = "Status Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StatusDate { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public int Earning { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public int Deduction { get; set; }

        [EnumDataType(typeof(DDEAList))]
        public DDEAList DDEA { get; set; }

        [Column(TypeName = "char(3)")]
        [Display(Name = "Bank Code")]
        public string BankCode { get; set; }

        [Column(TypeName = "char(3)")]
        [Display(Name = "Branch Code")]
        public string BranchCode { get; set; }

        [Column(TypeName = "char(1)")]
        [Display(Name = "Account Type")]
        public string BankAccountType { get; set; }

        [Column(TypeName = "char(17)")]
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "char(50)")]
        [Display(Name = "Account Name")]
        public string AccountName { get; set; }

        //[Column(TypeName = "decimal(10,2)")]
        //public int Total { get; set; }

        //[Column(TypeName = "decimal(12,2)")]
        //public int LoanEntitlement { get; set; }

        //[Column(TypeName = "decimal(12,2)")]
        //public int LoanBalance { get; set; }

    }
}
