namespace Figma.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsServices questionsServices;

        public QuestionsController(IQuestionsServices questionsServices)
        {
            this.questionsServices = questionsServices;
        }

        // GET api/<QuestionsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var question = questionsServices.GetById(id);
            if (question == null) { return NotFound($"NO Question found with this id: {id}"); }
            else { return Ok(question); }
        }

        // POST api/<QuestionsController>
        [HttpPost]
        public IActionResult Post([FromBody] QuestionsDto dto)
        {
            if(!ModelState.IsValid) { return BadRequest(dto); }
            else
            {
                questionsServices.Create(dto);
                return Ok(dto);
            }
        }

        // PUT api/<QuestionsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] QuestionsDto dto)
        {
            if (!ModelState.IsValid) { return BadRequest(dto); }
            else
            {
                questionsServices.update(id, dto);
                return Ok(dto);
            }
        }

        // DELETE api/<QuestionsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var question = questionsServices.GetById(id);
            if (question == null) { return NotFound($"NO Question found with this id: {id}"); }
            else 
            { 
                questionsServices.Delete(id);
                return Ok(question); 
            }
        }
    }
}
