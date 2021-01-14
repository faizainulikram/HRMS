using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Models
{

    public static class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
    {
        //Personnel Information
        new Claim("Personnel Information HR", "Personnel Information HR"),
        new Claim("Personnel Information HOD","Personnel Information HOD"),
        new Claim("Personnel Information Employee","Personnel Information Employee"),

        //Payroll
        new Claim("Payroll", "Payroll"),
    };
    }
}
