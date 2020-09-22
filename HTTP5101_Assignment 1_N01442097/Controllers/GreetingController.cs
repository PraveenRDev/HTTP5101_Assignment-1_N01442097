using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_1_N01442097.Controllers
{
    public class GreetingController : ApiController
    {
        // POST /api/Greeting -> "Hello World!"
        public string Post()
        {
            return "Hello World!";
        }

        // GET /api/Greeting/5 -> "Greetings to 5 people!"
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
