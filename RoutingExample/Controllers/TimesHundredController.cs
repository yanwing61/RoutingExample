using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RoutingExample.Controllers
{
    public class TimesHundredController : ApiController
    {
        //GET: api/TimesHundred/90 --> 900
        public int Get(int id)
        {
            return id * 100;
        }

        //POST: api/TimesFifty/5 -> 250
        public int Post(int id)
        {
            return id * 50;
        }

        //GET: api/TimesHundred/Math/x/y --> x*y
        [HttpGet]
        [Route("api/TimesHundred/Math/{operand1}/{operand2}")]
        public int Math(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        //POST: api/TimesFifty/greeting3 --> "heya"
        [HttpPost]
        public string Greeting3()
        {
            return "heya";
        }
    }
}
