using Microsoft.AspNetCore.Mvc;
using SOC_Project.FunctionFiles;
using System.Diagnostics.Eventing.Reader;

namespace SOC_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainRouteController : Controller
    {

        [HttpPost]
        [Route("CreateTrain")]
        public IActionResult CreateTrain(TrainRoute createLocation)
        {


            if (WebTokenValidate.TokenValidateing(createLocation.Token)) 
            {
                try
                {
                    string query = "";
                }
                catch(Exception ex)
                {
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400, // Or a more appropriate code based on the error
                        SMessage = "An error occurred while creating the train route. Please check your input data."
                    });
                }
            }
            else{
                return Unauthorized(new StatusMessage{
                    SCode=401,
                    SMessage= "unauthorized token"
                });
            }                  
        }
    }
    public class TrainRoute
    {
        public string Token {  get; set; }  
        public int TrainId { get; set; }
        public string SourLocatin { get; set; }
        public string DestLocation { get; set; }       
        public DateTime SchaduleTime {  get; set; }
        public int CreatedUser {  get; set; }
        public bool IsActive {  get; set; }
    }
}
