namespace Figma.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StagesController : ControllerBase
    {
        private readonly IStageServices stageServices;

        public StagesController(IStageServices stageServices)
        {
            this.stageServices = stageServices;
        }

        // GET api/<StagesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var stage = stageServices.GetById(id);
            if (stage == null) { return NotFound($"NO stage found with this id: {id}"); }
            else { return Ok(stage); }
        }

        // POST api/<StagesController>
        [HttpPost]
        public IActionResult Post([FromBody] StageDto dto)
        {
            if (!ModelState.IsValid) { return BadRequest(dto); }
            else
            {
                stageServices.Create(dto);
                return Ok(dto);
            }
        }

        // PUT api/<StagesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] StageDto dto)
        {
            if (!ModelState.IsValid) { return BadRequest(dto); }
            else
            {
                stageServices.Update(id, dto);
                return Ok(dto);
            }
        }

        // DELETE api/<StagesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var stage = stageServices.GetById(id);
            if (stage == null) { return NotFound($"NO Question found with this id: {id}"); }
            else {
                stageServices.Delete(id);
                return Ok(stage); }
        }
    }
}
