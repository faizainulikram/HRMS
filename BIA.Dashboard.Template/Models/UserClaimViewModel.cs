using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BIA.Dashboard.Template.Models
{
    public class UserClaimViewModel
    {
        public string ClaimType { get; set; }
        public bool IsSelected { get; set; }
    }
}
