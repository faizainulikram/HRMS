using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Models
{
    public class EmergencyContactUser
    {
        public int EmergencyContactUserId { get; set; }
        public string Name { get; set; }
        public string Relationship { get; set; }

        //[RegularExpression(@"^\d+$")]
        public string ContactNumber { get; set; }

        public int? PersonnelInformationUserId { get; set; }
        public PersonnelInformationUser PersonnelInformationUser { get; set; }
    }
}