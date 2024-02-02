using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class HostingCostController : ApiController
    {

        /// <summary>
        /// Calculate the total cost as per the number of days ({id}).
        /// </summary>
        /// <param name="id">Represents the number of days.</param> 
        /// <returns>Returns a string with the total cost of hosting with days.</returns>
        /// <example>
        /// GET /api/HostingCost/0  => "1 fortnight at $5.50/FN = $5.50 CAD", "HST 13% = $0.72 CAD", "Total = $6.22 CAD"
        /// GET /api/HostingCost/14 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        /// GET /api/HostingCost/15 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        /// GET /api/HostingCost/21 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        /// GET /api/HostingCost/28 => "3 fortnights at $5.50/FN = $16.50 CAD", "HST 13% = $2.14 CAD", "Total = $18.64 CAD"
        /// </example>
        public string[] Get(int id)
        {
            // Cost calculation
            double costPerFn = 5.50;
            double hstAmount = 0.13;

            // Calculate the number of fortnights and total hosting cost
            int fortnights = (id / 14) + 1;
            double subTotal = costPerFn * fortnights;
            double finalHST = subTotal * hstAmount;
            double totalHostingCost = subTotal + finalHST;

            // Response strings describing the total hosting cost
            string costResult = $"{fortnights} fortnights at ${costPerFn:F2}/FN = ${subTotal:F2} CAD";
            string hstResult = $"HST {hstAmount * 100}% = ${finalHST:F2} CAD";
            string totalResult = $"Total hosting cost = ${totalHostingCost:F2} CAD";

            // Return the response as an array of strings
            return new string[]
            {
                costResult,
                hstResult,
                totalResult
            };
        }
    }
}