using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assign2_CarrieNg.Controllers
{
    public class J2Controller : ApiController
    {
        /// Adapted J2: Roll the Dice
        /// <summary>
        /// Determine how may ways 2 dies can roll sides that add up to 10
        /// </summary>
        /// <param name="m"> the input for the number of sides on the first die
        /// </param>
        /// <param name="n"> the input for the number of sides on the second die
        /// </param>
        /// <example>
        /// Get api/J2/DiceGame/10/6 -> There are 6 ways to sum to 10.
        /// </example>
        /// <returns>
        /// Returns how many ways the dies sum up to 10.
        /// </returns>
        
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]

        public string DiceGame(int m, int n)
        {
            int die1;
            int die2;
            int counter = 0;

            if (m>n){
                die1 = n;
                die2 = m;
               
            } else{ 
                die1 = m;
                die2 = n;
            } 

            for (int i = 1; i <= die1; i++)
            {
                int x = 10-i;
                if (x<=die2 && x>0)
                {
                    counter++;
                } 

            }

            string solution = "";
            if(counter >1){
                solution = "There are " + counter.ToString() + " ways to sum to 10.";
            }
            else{
                solution = "There is " + counter.ToString() + " way to sum to 10.";
            }
                
            return solution;
        }

    }
}
