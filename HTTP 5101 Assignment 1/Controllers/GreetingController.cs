using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{

    public class GreetingController : ApiController
    {
        /// <summary>
        /// Return a "Hello World!" greeting.
        /// </summary>
        /// <example>
        /// POST /api/Greeting -> "Hello World!"
        /// </example>
        public string Post()
        {
            string greeting = "Hello World!";
            return greeting;
        }

        /// <summary>
        /// Return a greeting to a number of people, based on the ID.
        /// </summary>
        /// <param name="id">The number of people being greeted</param>
        /// <returns>"Greetings to {id} people!</returns>
        /// <example>
        /// GET /api/Greeting/6 -> "Greetings to 6 people!"
        /// GET /api/Greeting/3 -> "Greetings to 3 people!"
        /// GET /api/Greeting/0 -> "Greetings to 0 people!"
        /// </example>
        public string Get(int id)
        {
            // Greeting message with the number of people who specified in the ID 
            string greeting = "Greetings to " + id + " people!";
            return greeting;

        }
    }
}