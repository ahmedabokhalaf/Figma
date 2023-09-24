
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Figma.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {      
        private readonly IEducationServices educationServices;

        public EducationsController(IEducationServices educationServices)
        {
            this.educationServices = educationServices;
        }

        // GET api/<EducationsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var edu = educationServices.GetById(id);
            if(edu == null) { return NotFound($"NO Education found with this id: {id}"); }
            else { return Ok(edu); }
        }

        // POST api/<EducationsController>
        [HttpPost]
        public IActionResult Post([FromBody] EducationDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(dto);
            else
            {
                educationServices.Create(dto);
                return Ok(dto);
            }
        }

        // PUT api/<EducationsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EducationDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(dto);
            else
            {
                educationServices.Update(id, dto);
                return Ok(dto);
            }
        }

        // DELETE api/<EducationsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var edu = educationServices.GetById(id);
            if (edu == null) { return NotFound($"NO Education found with this id: {id}"); }
            else 
            { 
                educationServices.Delete(id);
                return Ok(edu); 
            }
        }
    }
}
