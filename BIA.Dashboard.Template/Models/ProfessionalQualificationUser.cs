using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Models
{
    public class ProfessionalQualificationUser
    {
        public int ProfessionalQualificationUserId { get; set; }

        [Display(Name = "Professional Qualification")]
        public string Name { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }

        public int? PersonnelInformationUserId { get; set; }
        public PersonnelInformationUser PersonnelInformationUser { get; set; }
    }
}
