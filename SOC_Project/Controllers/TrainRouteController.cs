using Microsoft.AspNetCore.Mvc;
using SOC_Project.FunctionFiles;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace SOC_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainRouteController : Controller
    {

        [HttpPost]
        [Route("CreateTrain")]
        public IActionResult CreateTrainRoute(TrainRoute routeData)
        {
            if (WebTokenValidate.TokenValidateing(routeData.Token)) 
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                    new SqlParameter("@TrainID",routeData.TrainId),
                    new SqlParameter("@SourLocation",routeData.SourLocatin),
                    new SqlParameter("@DestLocation",routeData.DestLocation),
                    new SqlParameter("@SchaduleTime",routeData.SchaduleTime),
                    new SqlParameter("@CreatedUser",routeData.CreatedUser),
                    new SqlParameter("@CreatedDate",DateTime.Now.ToString()),
                    new SqlParameter("@IsActive",routeData.IsActive)
                    };
                    string query = "INSERT INTO [dbo].[tbl_TrainRoute] ([TrainID] ,[SourLocation] ,[DestLocation] ,[SchaduleTime] ,[CreatedUser] ,[CreatedDate] ,[IsActive]) VALUES (@TrainID, @SourLocation, @DestLocation, @SchaduleTime, @CreatedUser, @CreatedDate, @IsActive)";
                    if (SQLConnection.PrmWrite(query, sqlParameters)) {
                        return Ok(new StatusMessage
                        {
                            SCode = 200,
                            SMessage="Train route Insert"
                        });
                    }
                    else
                    {
                        return BadRequest(new StatusMessage
                        {
                            SCode = 500, // Or a more appropriate code based on the error
                            SMessage = "An internal error occurred while creating the train route. Please check your input data."
                        });
                    }
                   
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
