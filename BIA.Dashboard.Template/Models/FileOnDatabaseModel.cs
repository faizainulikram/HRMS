using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BIA.Dashboard.Template.Models;

namespace BIA.Dashboard.Template.Models
{
    public class FileOnDatabaseModel : FileAttachments
    {
        public byte[] Data { get; set; }
    }
}
