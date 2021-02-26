using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assingment2_N01454501.Controllers
{
    public class TelemarketerController : ApiController
    {
        /// <summary>
        /// 
        ///  J1 PROBLEM 2018 ccc Telemarketer or not
        /// 
        ///  
        ///  To check to see whether the seven digit number is a telemarketer number or not through the last 4 digits og the code and as follows:
        ///  1.the first of these four digits is an 8 or 9;
        ///  2. the last digit is an 8 or 9;
        ///  3. the second and third digits are the same
        /// </summary>
        /// <param name="num1">first number out of seven</param>
        /// <param name="num2">second number out of seven</param>
        /// <param name="num3">third number out of seven</param>
        /// <param name="num4">fourth number out of seven</param>
        /// <param name="num5">fifth number out of seven</param>
        /// <param name="num6">sixth number out of seven</param>
        /// <param name="num7">seventh number out of seven</param>
        /// <example>
        ///  api/LoopExample/Telemarketer/3/4/2/9/6/6/8   =>   Ignore  
        ///  api/LoopExample/Telemarketer/1/4/5/5/6/6/8   =>   Answer 
        /// </example>
        /// <returns>Ignore OR Answer</returns>
        [HttpGet]
        [Route("api/Telemarketer/TeleNumber/{num1}/{num2}/{num3}/{num4}/{num5}/{num6}/{num7}")]
        public string TeleNumber(int num1, int num2, int num3, int num4, int num5, int num6, int num7)
        {
            string Output;
            if (num4 == 8 || num4 == 9 && num5 == num6 && num7 == 8 || num7 == 9)
            {
                Output = "Ignore";
            }
            else
            {
                Output = "Answer";

            }

            return Output;
        }

    }
}
