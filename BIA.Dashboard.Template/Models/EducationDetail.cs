using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Models
{
    public class EducationDetail
    {
        public int EducationDetailId { get; set; }

        public string Education { get; set; }
        public string Institution { get; set; }
        public string Year { get; set; }

        public int? PersonnelInformationId { get; set; }
        public PersonnelInformation PersonnelInformation { get; set; }
    }
}
