using BIA.Dashboard.Template.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Models
{
    public class HealthDeclaration
    {
        [ForeignKey("PersonnelInformation")]
        public int HealthDeclarationId { get; set; }

        public bool Disease { get; set; }
        public string DiseaseDesc { get; set; }

        public string MedicalCondition { get; set; } //multiselect
        public string MedicalConditionDesc { get; set; }
        public string OtherMedicalCondition { get; set; }

        public string Medication { get; set; }

        public string ComplexHealthProblem { get; set; } //multiselect
        public string ComplexHealthProblemDesc { get; set; }
        public bool Declaration { get; set; }
        public DateTime Date { get; set; }

        public int PersonnelInformationId { get; set; }
        public virtual PersonnelInformation PersonnelInformation { get; set; }
    }
}
