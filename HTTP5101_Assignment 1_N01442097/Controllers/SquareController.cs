using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_1_N01442097.Controllers
{
    public class SquareController : ApiController
    {
        // GET /api/Square/10 -> 20
        public int Get(int id)
        {
            return id * id;
        }
    }
}
