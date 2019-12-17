using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;

namespace DataManager1.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        /// <summary>
        /// This will list al dtails 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        //public IHttpActionResult Get()
        {
            string userID = RequestContext.Principal.Identity.GetUserId();
            // Ok(new string[] { "value1", "value2", userID }) belong to IHTTPACTIONRESULT
            return new string[] { "value1", "value2", userID };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// this will provide details for Id
        /// </summary>
        /// <param name="Id"></param>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        [HttpPost]
        [Route("upload")]
        public void PostFile(IFormFile uploadedFile)
        {
            //TODO: Save File
        }
        //////////////////////////// The above input parameter was uploaded with Microsoft.AspNet.Http in order to upload 
        //////////////////////////// files to Swagger. This was done so that I may upload an image. IT IS VERY IMPORTANT THAT I DO 
        //////////////////////////// NOT FORGET ABOUT THIS SYSTEM PLACED HERE FOR I WILL USE IT IN THE FUTURE TO CONTINUE THIS PROJECT 
        ////////////////////////////AND FINALLY UPLOAD AN IMAGE TO THE API. CURRENTLY THE API IS RUNNING IN .NETFRAMEWORK however 
        ////////////////////////////I will complete this later down the road to ensure that everything is copacetic. 
        ////////////////////////////while downloading the nuget package I accidentilly may have downloaded the wrong file
        ////////////////////////////I must ensure that nothing unnessecary is downloaded. 
        ////////////////////////////See bookmarks in chrome for link on how to enable file upload in .net core.
    }
}
