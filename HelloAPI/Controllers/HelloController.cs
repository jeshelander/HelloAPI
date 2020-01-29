using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloAPI.Models;

namespace HelloAPI.Controllers
{
    public class HelloController : ApiController
    {
        HellotoAll hello = new HellotoAll();

        [HttpGet]
        public string Hello()
        {
            return hello.HelloWorld;
        }

        [HttpPost]
        public string Hello(string setGreeting)
        {
            hello.HelloWorld = setGreeting;
            return "New value set.";
        }
    }
}
