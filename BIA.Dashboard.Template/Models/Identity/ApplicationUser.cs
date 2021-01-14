using System;
using Microsoft.AspNetCore.Identity;
using BIA.Dashboard.Template.Models;

namespace BIA.Dashboard.Template.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public PersonnelInformation PersonnelInformation { get; set; }
        public PersonnelInformationUser PersonnelInformationUser { get; set; }

        public bool? IsEnabled { get; set; }
    }
}
