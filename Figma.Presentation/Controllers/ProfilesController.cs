
namespace Figma.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly IProfileServices profileServices;

        public ProfilesController(IProfileServices profileServices)
        {
            this.profileServices = profileServices;
        }

        // GET api/<ProfilesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var profile = profileServices.GetById(id);
            if (profile == null) { return NotFound($"NO profile found with this id: {id}"); }
            else { return Ok(profile); }
        }

        // POST api/<ProfilesController>
        [HttpPost]
        public IActionResult Post([FromForm] ProfileDto dto)
        {
            if (!ModelState.IsValid) { return BadRequest(dto); }
            else
            {
                profileServices.Create(dto);
                return Ok(dto);
            }
        }

        // PUT api/<ProfilesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromForm] ProfileDto dto)
        {
            if (!ModelState.IsValid) { return BadRequest(dto); }
            else
            {
                profileServices.Update(id, dto);
                return Ok(dto);
            }
        }

        // DELETE api/<ProfilesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var profile = profileServices.GetById(id);
            if (profile == null) { return NotFound($"NO profile found with this id: {id}"); }
            else {
                profileServices.Delete(id);
                return Ok(profile); 
            }
        }
    }
}
