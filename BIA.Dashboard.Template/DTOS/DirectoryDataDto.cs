using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.DTOS
{
    public class DirectoryDataDto
    {

        public string Name { get; set; }
        public string ExtensionNumber { get; set; }

        public string Position { get; set; }

        public string Division { get; set; }
        public string Action { get; set; }
        public int PersonnelId { get; set; }

    }
}
