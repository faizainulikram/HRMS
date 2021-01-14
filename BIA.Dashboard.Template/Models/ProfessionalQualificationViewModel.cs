using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Models
{
    public class ProfessionalQualificationViewModel
    {
        public int ProfessionalQualificationId { get; set; }

        [Display(Name = "Professional Qualification")]
        public string Name { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }

        public int? PersonnelInformationId { get; set; }
        public PersonnelInformation PersonnelInformation { get; set; }
    }
}
