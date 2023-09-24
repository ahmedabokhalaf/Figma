
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Figma.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationFormsController : ControllerBase
    {
        private readonly IApplicationFormServices applicationFormServices;

        public ApplicationFormsController(IApplicationFormServices applicationFormServices)
        {
            this.applicationFormServices = applicationFormServices;
        }


        // GET api/<ApplicationFormsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var app = applicationFormServices.GetById(id);
            if(app == null)
            {
                return NotFound($"No Application Form with this Id: {id}");
            }
            return Ok(app);
        }

        // POST api/<ApplicationFormsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromForm]ApplicationFormDto dto)
        {
            if(!ModelState.IsValid) { return BadRequest(dto); }
            else
            {
                await applicationFormServices.Create(dto);
                return Ok(dto);
            }
        }

        // PUT api/<ApplicationFormsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromForm] ApplicationFormDto dto)
        {
            if (!ModelState.IsValid) { return BadRequest(dto); }
            else
            {
                await applicationFormServices.Update(id, dto);
                return Ok(dto);
            }
        }
    }
}
