using Microsoft.AspNetCore.Mvc;
using SOC_Project.FunctionFiles;

namespace SOC_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertLocationController : Controller
    {

        [HttpPost]
        [Route("CreateTrain")]
        public IActionResult CreateTrain(CreateLocation createLocation)
        {
          
                return Unauthorized(WebTokenValidate.TokenValidateing(createLocation.Token));
                  
        }
    }
    public class CreateLocation
    {
        public string Token {  get; set; }  
        public string DestLocation { get; set; }
        public string SourLocatin { get; set; }
        public DateTime StartTime {  get; set; }
    }
}
