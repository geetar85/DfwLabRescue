using DfwLabRescue.Web.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Hosting;
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

        [Route("api/imageupload")]
        [HttpPost]
        public async Task<FileResult> Upload()
        {
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            string root = System.Web.HttpContext.Current.Server.MapPath("~/assets/img/uploads/");
            var provider = new CustomMultipartFormDataStreamProvider(root); 



            var files = await Request.Content.ReadAsMultipartAsync(provider);
            
            var fileResult = new FileResult();
            foreach (var file in files.FileData)
            {
                var uploadedFileInfo = new FileInfo(file.LocalFileName);
                fileResult.files.Add(new File { name = uploadedFileInfo.Name, size = uploadedFileInfo.Length, url = Url.Content("~/assets/img/uploads/" + uploadedFileInfo.Name) });                
            }
            
            return fileResult;
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

    public class FileResult
    {
        public FileResult()
        {
            files = new List<File>();
        }
        public List<File> files { get; set; }
    }

    public class File
    {
        public string name { get; set; }
        public string url { get; set; }
        public long size { get; set; }
    }

    public class CustomMultipartFormDataStreamProvider : MultipartFormDataStreamProvider
    {
        public CustomMultipartFormDataStreamProvider(string path)
            : base(path)
        { }

        public override string GetLocalFileName(System.Net.Http.Headers.HttpContentHeaders headers)
        {
            var name = !string.IsNullOrWhiteSpace(headers.ContentDisposition.FileName) ? headers.ContentDisposition.FileName : "NoName";
            return name.Replace("\"", string.Empty); //this is here because Chrome submits files in quotation marks which get treated as part of the filename and get escaped
        }
    }
}
