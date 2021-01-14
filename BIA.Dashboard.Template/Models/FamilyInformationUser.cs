using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Models
{
    public class FamilyInformationUser
    {
        public int FamilyInformationUserId { get; set; }
        public string Name { get; set; }

        [Display(Name = "Identity Card Number")]
        //[RegularExpression(@"^\d{2}-\d{6}$"), StringLength(9)]
        public string IdentityCardNumber { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }
        public string Position { get; set; }
        public string Employer { get; set; }
        public string Relationship { get; set; }

        public int? PersonnelInformationUserId { get; set; }
        public PersonnelInformationUser PersonnelInformationUser { get; set; }
    }
}
