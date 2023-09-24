namespace Figma.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInfosController : ControllerBase
    {
        private readonly IPersonalInfoServices personalInfoServices;

        public PersonalInfosController(IPersonalInfoServices personalInfoServices)
        {
            this.personalInfoServices = personalInfoServices;
        }

        // GET api/<PersonalInfosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var info = personalInfoServices.GetById(id);
            if (info == null) { return NotFound($"NO Information found with this id: {id}"); }
            else { return Ok(info); }
        }

        // POST api/<PersonalInfosController>
        [HttpPost]
        public IActionResult Post([FromBody] PersonalInfoDto dto)
        {
            if (!ModelState.IsValid) {  return BadRequest(dto); }
            else
            {
                personalInfoServices.Create(dto);
                return Ok(dto);
            }
        }

        // PUT api/<PersonalInfosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PersonalInfoDto dto)
        {
            if (!ModelState.IsValid) { return BadRequest(dto); }
            else
            {
                personalInfoServices.Update(id, dto);
                return Ok(dto);
            }
        }

        // DELETE api/<PersonalInfosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var info = personalInfoServices.GetById(id);
            if (info == null) { return NotFound($"NO Information found with this id: {id}"); }
            else 
            { 
                personalInfoServices.Delete(id);
                return Ok(info); 
            }
        }
    }
}
