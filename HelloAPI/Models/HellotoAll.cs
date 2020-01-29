using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloAPI.Models
{
    public class HellotoAll
    {
        public string HelloWorld { get; set; }
        
        public HellotoAll ()
        {
            HelloWorld = "Hello World!!";
        }
    }
}