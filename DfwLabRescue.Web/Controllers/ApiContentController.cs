using DfwLabRescue.Web.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
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

        [Route("api/Content")]
        [HttpPost]
        [Authorize]
        public HttpResponseMessage PostContent(JObject raptorContent)
        {
            JObject raptorObject = JsonConvert.DeserializeObject<JObject>(raptorContent["raptorContent"].ToString());
            string contentId = raptorObject.Properties().First().Name;
            string updatedContent = raptorObject.Property(contentId).Value.ToString();

            var content = DB.AllContent.FirstOrDefault(c => c.ContentId == contentId);
            content.RawHtml = updatedContent;
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
    public class Bla
    {
        public RaptorContent Foster { get; set; }
    }

    public class RaptorContent
    {
        public string Foster { get; set; }
        
    }
}
