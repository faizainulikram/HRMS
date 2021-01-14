using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Models
{
    public class UserClaimsViewModel
    {
        public UserClaimsViewModel()
        {
            Claims = new List<UserClaimViewModel>();
        }
        public string Id { get; set; }
        public List<UserClaimViewModel> Claims { get; set; }
    }
}
