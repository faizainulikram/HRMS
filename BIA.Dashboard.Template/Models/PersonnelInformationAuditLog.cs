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
    public class PersonnelInformationAuditLog
    {
        public PersonnelInformationAuditLog()
        {
            this.FormattedStatusDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        [Key]
        public int PersonnelInformationAuditLogId { get; set; }

        public string Status { get; set; }
        public int PersonnelInformationId { get; set; }
        public virtual PersonnelInformation PersonnelInformation { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "Status Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime? StatusDate { get; set; }

        public string FormattedStatusDate { get; set; }
    }
}
