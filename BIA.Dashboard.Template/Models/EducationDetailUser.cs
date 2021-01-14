using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Models
{
    public class EducationDetailUser
    {
        public int EducationDetailUserId { get; set; }

        public string Education { get; set; }
        public string Institution { get; set; }
        public string Year { get; set; }

        public int? PersonnelInformationUserId { get; set; }
        public PersonnelInformationUser PersonnelInformationUser { get; set; }
    }
}
