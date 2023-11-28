using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesApplicationSolution.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class TesztController : ControllerBase
    {
        [HttpGet]
        [Route("corvinus/szerverido")]
        public IActionResult M1()
        {
            string pontosIdő = DateTime.Now.ToShortTimeString();

            return new ContentResult
            {
                ContentType = System.Net.Mime.MediaTypeNames.Text.Plain, //"text/plain"
                Content = pontosIdő
            };
            //vagy rövidebben:

            //string pontosIdő = DateTime.Now.ToShortTimeString();
            //return Ok(pontosIdő);
        }


        [HttpGet]
        [Route("corvinus/nagybetus/{szoveg}")]
        public IActionResult M2(string szoveg)
        {
            return new ContentResult
            {
                ContentType = System.Net.Mime.MediaTypeNames.Text.Plain, //"text/plain"
                Content = szoveg.ToUpper()
            };

            //Vagy egyszerűbben:
            //return Ok(szoveg.ToUpper());

            //return BadRequest("Nem jó a bemenő adat");
        }
    }
}
