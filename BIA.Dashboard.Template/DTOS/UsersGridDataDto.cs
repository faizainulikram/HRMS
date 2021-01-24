using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.DTOS
{
    public class UsersGridDataDto
    {
        public string User { get;  set; }
        public string Status { get;  set; }
        public bool? IsEnabled { get;  set; }
        public string Id { get;  set; }
        public string Action { get;  set; }
        public string Username { get;  set; }
    }
}
