using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DfwLabRescue.Web.Models
{
    public class Model
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
