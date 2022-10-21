using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assign2_CarrieNg.Controllers
{
    /// 2014 CCC J1: Triangle Times
    /// <summary>
    /// Determines if the if the angle inputs add up to the angles in a triangle, and then determined 
    /// if it is an equilatoral, scalene, or Isosceles triangle
    /// </summary>
    /// <param name="a1"> the input for the first angle
    /// </param>
    /// <param name="a2"> the input for the second angle
    /// </param>
    /// <param name="a3"> the input for the third angle
    /// </param>
    /// <example>
    /// Get api/J1/triangle/60/60/60 -> Equilatroal 
    /// </example>
    /// <returns>
    /// Equilatorl, scalene, Isosceles, or Error (not a triangle)
    /// </returns>
    public class J1Controller : ApiController
    {
        [Route("api/J1/triangle/{a1}/{a2}/{a3}")]
        [HttpGet]
        public string triangle(int a1, int a2, int a3)
        {

            int angles = a1 + a2 + a3;

            if (angles == 180)
            {
                if (a1 == a2 && a1==a3 && a2==a3)
                {
                    return "Equilateral";
                }
                else if (a1 != a2 && a1 != a3 && a2 != a3)
                {
                    return "Scalene";
                }
                else
                {
                    return "Isosceles";
                }

            }
            return "Error";




        }

    }
}
