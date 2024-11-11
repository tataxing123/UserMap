using Map.DAL.DbContexts;
using Map.DAL.DbServices;
using Microsoft.AspNetCore.Mvc;

namespace Map.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapController : ControllerBase
    {

        private readonly DataService _dataService =  new DataService();

        [Route("GetUserLocations")]
        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllUserLocations()
        {
            return Ok(await _dataService.GetAllUserLocations());
        }
    }
}