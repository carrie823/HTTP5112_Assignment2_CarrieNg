using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assign2_CarrieNg.Controllers
{
    public class J3Controller : ApiController
    {
        /// 2011 CCC J3: Sumac Sequences 
        /// <summary>
        /// Subtracts the first input (T1) from the second input (T2). That value becomes the
        /// the next input in the sequnce, will be subtracted from the previous number in the sequence. This loop will continue until
        /// until the last number in the sequnce is larger than the 2nd last.Then it will display the lenth of the number sequence.
        /// </summary>
        /// <param name="T1"></param> The input for the first number in the sequence
        /// <param name="T2"></param> The input for the second number in the sequence
        /// <example>
        /// GET api/J3/numSequence/80/30 -> 3
        /// </example>
        /// <returns>
        /// the lenth of the number sequence.
        /// </returns>
        
        [Route("api/J3/numSequence/{T1}/{T2}")]
        [HttpGet]

        public int numSequence(int T1, int T2)
        {
            int counter = 2;

            while (T2<T1)
            {
                int T3 = T1-T2; ///T3 is the next element in the the sequence of numbers
                T1=T2;
                T2=T3;
                counter++;
            } 
            return counter;

        }
    }
}
