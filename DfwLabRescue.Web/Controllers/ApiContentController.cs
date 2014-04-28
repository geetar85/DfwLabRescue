using DfwLabRescue.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DfwLabRescue.Web.Controllers
{
    public class ApiContentController : ApiController
    {
        [Route("api/Content/{contentId}")]
        [HttpGet]
        public HttpResponseMessage RetrieveContent(string contentId, bool published = true)
        {
            var content = DB.AllContent.FirstOrDefault(c => c.ContentId == contentId && c.Published == published);

            if (content == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Content Not Found");

            return Request.CreateResponse(content.RawHtml);
        }
    }
}
