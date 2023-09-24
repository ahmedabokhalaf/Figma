namespace Figma.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkExperiencesController : ControllerBase
    {
        private readonly IWorkExperienceServices workExperienceServices;

        public WorkExperiencesController(IWorkExperienceServices workExperienceServices)
        {
            this.workExperienceServices = workExperienceServices;
        }

        // GET api/<WorkExperiencesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var exp = workExperienceServices.GetById(id);
            if (exp == null) { return NotFound($"NO Experience found with this id: {id}"); }
            else { return Ok(exp); }
        }

        // POST api/<WorkExperiencesController>
        [HttpPost]
        public IActionResult Post([FromBody] WorkExperienceDto dto)
        {
            if (!ModelState.IsValid) { return BadRequest(dto); }
            else
            {
                workExperienceServices.Create(dto);
                return Ok(dto);
            }
        }

        // PUT api/<WorkExperiencesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WorkExperienceDto dto)
        {
            if(!ModelState.IsValid) { return BadRequest(dto); }
            else { 
                workExperienceServices.Update(id, dto);
                return Ok(dto);
            }
        }

        // DELETE api/<WorkExperiencesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var exp = workExperienceServices.GetById(id);
            if (exp == null) { return NotFound($"NO Experience found with this id: {id}"); }
            else {
                workExperienceServices.Delete(id);
                return Ok(exp); 
            }
        }
    }
}
