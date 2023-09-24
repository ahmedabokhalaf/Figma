
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Figma.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FigmaProgramsController : ControllerBase
    {
        private readonly IFigmaProgramServices programServices;

        public FigmaProgramsController(IFigmaProgramServices programServices)
        {
            this.programServices = programServices;
        }

        // GET api/<FigmaProgramsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var program = programServices.GetById(id);
            if (program == null) { return NotFound($"NO Program found with this id: {id}"); }
            else { return Ok(program); }
        }

        // POST api/<FigmaProgramsController>
        [HttpPost]
        public IActionResult Post([FromBody] FigmaProgramDto dto)
        {
            if(!ModelState.IsValid) { return BadRequest(dto); }
            else 
            { 
                programServices.Create(dto);
                return Ok(dto); 
            }
        }

        // PUT api/<FigmaProgramsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] FigmaProgramDto dto)
        {
            var program = programServices.GetById(id);
            if (program == null) { return NotFound($"NO Program found with this id: {id}"); } 
            else
            {
                programServices.Update(id, dto);
                return Ok(program);
            }
        }

    }
}
