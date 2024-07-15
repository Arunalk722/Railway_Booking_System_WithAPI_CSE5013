using Microsoft.AspNetCore.Mvc;
using SOC_Project.FunctionFiles;
using System.Data.SqlClient;

namespace SOC_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainCreateController : Controller
    {
        [HttpPost]
        [Route("Create")]
        public IActionResult Index(MakeTrainList makeTrain)
        {
            if (!WebTokenValidate.TokenValidateing(makeTrain.Token))
            {
                return Unauthorized(new StatusMessage
                {
                    SCode = 401,
                    SMessage = "unauthorized token"
                });
            }
            else
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                   {
                    new SqlParameter("@TrainName",makeTrain.TrainName),
                    new SqlParameter("@IsActive",'1'),
                    new SqlParameter("@CreatedDate",DateTime.Now.ToString()),
                   };
                    string query = "INSERT INTO [dbo].[tbl_TrainList] ([TrainName] ,[IsActive] ,[CreatedDate]) VALUES (@TrainName, @IsActive, @CreatedDate)";
                    if (SQLConnection.PrmWrite(query, sqlParameters))
                    {
                        return Ok(new StatusMessage
                        {
                            SCode = 200,
                            SMessage = "New Train add"
                        });
                    }
                    else
                    {
                        return BadRequest(new StatusMessage
                        {
                            SCode = 500, // Or a more appropriate code based on the error
                            SMessage = "An internal error occurred while creating the train. Please check your input data."
                        });
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400, // Or a more appropriate code based on the error
                        SMessage = "An error occurred while creating the train. Please check your input data."
                    });
                }
            }
            return View();
        }
    }
    public class MakeTrainList
    {
        public string Token { get; set; }
        public string TrainName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}