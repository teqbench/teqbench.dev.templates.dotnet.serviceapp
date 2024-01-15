using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeqBench.Dev.Templates.DotNet.ServiceApp.Controllers
{
    /// <summary>
    /// Example controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/teqbench/template-servicepp/[controller]")]
    public class ExampleController : ControllerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleController" /> class.
        /// </summary>
        public ExampleController()
        {
        }

        /// <summary>
        /// Gets all of the position documents from the DB
        /// </summary>
        /// <returns>List of position documents.</returns>
        [HttpGet("helloworld")]
        public IActionResult Get()
        {
            return Ok("Hello world");
        }
    }
}
