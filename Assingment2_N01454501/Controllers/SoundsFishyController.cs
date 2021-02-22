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
        /// J2 PROBLEM
        /// 
        /// 4 readings which are  incremental, decreamental and mixed reading each given an output. 
        /// </summary>
        /// <param name="reading1"> 1st reading</param>
        /// <param name="reading2">2nd reading</param>
        /// <param name="reading3">3rd reading</param>
        /// <param name="reading4">4th reading</param>
        /// 
        ///  <example>
        ///  api/SoundsFishy/FishDepthMeasure/30/10/20/20  => "No Fish"
        ///  api/SoundsFishy/FishDepthMeasure/1/10/12/13   => "Fish Rising"
        ///  api/SoundsFishy/FishDepthMeasure/30/30/30/30  => "Fish at Constant Depth"
        ///  api/SoundsFishy/FishDepthMeasure/30/24/12/6   => "Fish Diving"
        /// </example>
        /// <returns>
        /// "Fish at Constant Deepth"
        /// "Fish Rising"
        /// "Fish Diving"
        /// </returns>

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
