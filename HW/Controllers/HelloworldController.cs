using HW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HW.Controllers
{
    public class HelloworldController : ApiController
    {
        static List<Helloworld> helloworld = new List<Helloworld>()
        {
            new Helloworld(){ ID = 0, AppName = "Hello World!" },
            new Helloworld(){ ID = 1, AppName = "Hello" },
            new Helloworld(){ ID = 2, AppName = "World!" },

        };
        public IEnumerable<Helloworld> Get()
        {
            return helloworld;
        }
        public IHttpActionResult Get(int id)
        {
            var helloworlds = helloworld.FirstOrDefault((p) => p.ID == id);
            if (helloworlds == null)
            {
                return NotFound();
            }
            return Ok(helloworlds);
        }

    }
}
