using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Models
{
    public class FileAttachments
    {
        [Key]
        public int FileAttachmentId { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public DateTime? CreatedOn { get; set; }

        public int PersonnelInformationId { get; set; }
        public int PersonnelInformationUserId { get; set; }
    }
}
