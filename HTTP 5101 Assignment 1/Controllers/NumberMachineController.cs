using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Receives an input integer number and applies four mathematical operations on it. Truncates the result to an integer.
        /// </summary>
        /// <param name="id">The input number to perform four mathematical operations on.</param>
        /// <returns>The result of four mathematical operations (addition, subtraction, multiplication, division).</returns>
        /// <example>
        ///   GET /api/NumberMachine/10 => Addition = 25 Subtraction = -5 Multiplication = 150 Division = 10
        ///   GET /api/NumberMachine/-5 => Addition = 10 Subtraction = -20 Multiplication = -75 Division = -5
        ///   GET /api/NumberMachine/30 => Addition = 45 Subtraction = 15 Multiplication = 450 Division = 30
        /// </example>
        public string Get(int id)
        {
            // Four different mathematical operations on the input number
            int addRes = id + 15;
            int subRes = id - 15;
            int mulRes = id * 15;
            int divRes = id / 1;

            // Response message containing the results
            string numbermachine = $"Addition = {addRes} Subtraction = {subRes} Multiplication = {mulRes} Division = {divRes}";

            
            return numbermachine;
        }
    }
}

