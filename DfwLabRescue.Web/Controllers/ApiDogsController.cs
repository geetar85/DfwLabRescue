using DfwLabRescue.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DfwLabRescue.Web.Controllers
{
    public class ApiDogsController : ApiController
    {
        [Route("api/dogs/available")]
        [HttpGet]
        public IEnumerable<Dog> AvailableDogs(int p=0, int ps = 10)
        {
            var dogs = DB.Dogs.Where(d => d.AdoptionStatus == AdoptionStatus.Available).Skip(p).Take(ps);
            
            return dogs.ToList();
        }

        [Route("api/dogs")]
        [HttpGet]
        public IEnumerable<Dog> AllDogs(int p = 0, int ps = 10)
        {
            var dogs = DB.Dogs.Skip(p).Take(ps);

            return dogs.ToList();
        }
    }
}
