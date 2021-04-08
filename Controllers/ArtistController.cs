using System.Collections.Generic;
using artists.Models;
using artists.Services;
using Microsoft.AspNetCore.Mvc;

namespace artists.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistController
    {

        private readonly ArtistService _service;

        public ArtistController(ArtistService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Artist>> Get()
        {
            try
            {
                return Ok(_service.Get());
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }

    }
}