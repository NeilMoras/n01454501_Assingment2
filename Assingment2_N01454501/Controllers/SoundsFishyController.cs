using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assingment2_N01454501.Controllers
{
    public class SoundsFishyController : ApiController
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reading1"></param>
        /// <param name="reading2"></param>
        /// <param name="reading3"></param>
        /// <param name="reading4"></param>
        /// <returns></returns>

        [HttpGet]
        [Route("api/SoundsFishy/FishDepthMeasure/{reading1}/{reading2}/{reading3}/{reading4}")]
        public string FishDepthMeasure(int reading1, int reading2, int reading3, int reading4)
        {
            string ReadingOutput;



            if (reading1 == reading2 && reading2 == reading3 && reading3 == reading4)
            {
                ReadingOutput = "Fish at Constant Depth";
            }
            else if (reading1 < reading2 && reading2 < reading3 && reading3 < reading4)
            {
                ReadingOutput = "Fish Rising";

            }
            else if (reading1 > reading2 && reading2 > reading3 && reading3 > reading4)
            {
                ReadingOutput = "Fish Diving";
            }
            else
            {
                ReadingOutput = " No Fish";
            }
            return ReadingOutput;
        }

    }
}
