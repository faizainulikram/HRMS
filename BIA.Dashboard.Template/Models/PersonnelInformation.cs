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

    public class PersonnelInformation 
    {
        public PersonnelInformation()
        {
            this.EducationDetail = new List<EducationDetail>();
            this.ProfessionalQualification = new List<ProfessionalQualification>();
            this.EmergencyContact = new List<EmergencyContact>();
            this.FamilyInformation = new List<FamilyInformation>();
        }

        //personnel private profile
        [Key]
        public int PersonnelId { get; set; }

        [NotMapped]
        [Display(Name = "Profile Picture")]
        public IFormFile ProfileImage { get; set; }
        public string ProfileImageName { get; set; }

        [Display(Name = "Personnel ID/Number")]
        public string PersonnelNumber { get; set; }
        public string Prefix { get; set; }
        public string Name { get; set; }

        [Display(Name = "Identity Card Number")]
        //[RegularExpression(@"^\d{2}-\d{6}$"), StringLength(9)]
        public string IdentityCardNumber { get; set; }

        [Display(Name = "Identity Card Color")]
        public string IdentityCardColor { get; set; }
        public string Race { get; set; }
        public string Religion { get; set; }

        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }

        [Display(Name = "Home Number")]
        //[RegularExpression(@"^\d+$")]
        [StringLength(15)]
        public string HomeNumber { get; set; }

        [Display(Name = "Mobile Number")]
        //[RegularExpression(@"^\d+$")]
        public string MobileNumber { get; set; }

        //personnel career profile (to be linked with career management)
        [Display(Name = "Employment Status")]
        public string EmploymentStatus { get; set; }

        [Display(Name = "Reporting Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ReportingDate { get; set; }

        [Display(Name = "Confirmed Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ConfirmedDate { get; set; }

        //add auto calc
        //to note if unpaid leave is taken
        [Display(Name = "Service Duration")]
        public string ServiceDuration { get; set; }

        [Display(Name = "Reporting Date to Position")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? PositionReportingDate { get; set; }

        [Display(Name = "Reporting Date to Department")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DepartmentReportingDate { get; set; }

        [Display(Name = "Mandatory Retirement Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? MandatoryRetirementDate { get; set; }

        [Display(Name = "Current Position")]
        public string CurrentPosition { get; set; }

        [Display(Name = "Global Grade")]
        public string GlobalGrade { get; set; }

        public string Group { get; set; }
        public string Division { get; set; }

        [Display(Name = "Tel Extension Number")]
        public string ExtensionNumber { get; set; }
        public string Email { get; set; }

        //education detail (One2Many)
        public ICollection<EducationDetail> EducationDetail { get; set; }

        //professional qualification (One2Many)
        public ICollection<ProfessionalQualification> ProfessionalQualification { get; set; }

        //family information (One2Many)
        public ICollection<FamilyInformation> FamilyInformation { get; set; }

        //emergency contact (One2Many)
        public ICollection<EmergencyContact> EmergencyContact { get; set; }

        //health declaration (One2One)
        public virtual HealthDeclaration HealthDeclaration { get; set; }

        //application user (One2One)
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        //file attachments 
        [NotMapped]
        [Display(Name = "File Attachments")]
        public List<IFormFile> FileAttachments { get; set; }

        //lock after verification
        public bool Locked { get; set; }
    }
}
