using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RoutingExample.Controllers
{
    public class ChallengeController : ApiController
    {
        /// <summary>
        /// Calculate the volume of a prism given length, width, and height.
        /// </summary>
        /// <param name="x">The width of the volume in cm</param>
        /// <param name="y">The length of the volume in cm</param>
        /// <param name="z">The height of the volume in cm</param>
        /// <returns>
        /// The total volumne of the prism is {result} cm^3
        /// </returns>
        
        //GET: api/Challenge/Calculate/x/y/z --> The total volumne of the prism is {result} cm^3
        [HttpGet]
        [Route("api/Challenge/Calculate/{x}/{y}/{z}")]
        public string Calculate(int x, int y, int z)
        {
            int volume = x * y * z;
            string message = "The total volumne of the prism is " + volume + " cm^3";
            return message;
        }
    }
}
