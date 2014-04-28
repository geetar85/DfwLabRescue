using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DfwLabRescue.Web.Models
{
    public class Content
    {
        public string Title { get; set; }
        public string ContentId { get; set; }
        public bool Published { get; set; }
        public bool Breadcrumbs { get; set; }
        public string RawHtml { get; set; }
        public string CssFile { get; set; }
    }
}
