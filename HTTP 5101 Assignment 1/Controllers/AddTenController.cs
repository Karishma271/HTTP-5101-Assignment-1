using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Returns the input number Add 10
        /// </summary>
        /// <param name="number">The input number</param>
        /// <returns>The input with 10 Add</returns>
        /// example:
        /// GET /api/AddTen/21-> 31
        /// GET /api/AddTen/0-> 10
        /// GET /api/AddTen/-9-> 1
        public int Get(int id)
        {
            // Result variable for (id + 10)
            int result = id + 10;
            
            return result;
        }
    }
}