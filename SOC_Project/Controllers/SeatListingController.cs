using Microsoft.AspNetCore.Mvc;
using SOC_Project.FunctionFiles;
using System.Data.SqlClient;

namespace SOC_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatListingController : Controller
    {
        [HttpPost]
        [Route("/GetBookedSeatNo")]
        public IActionResult Index(CheckLocationRBody rBody)
        {
            if (!WebTokenValidate.TokenValidateing(rBody.Token))
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
                    List<TakedSeatList> setList = new List<TakedSeatList>();
                    SqlParameter[] checkLocation = new SqlParameter[] {
                    new SqlParameter("@TraindID",rBody.TrainID),
                    new SqlParameter("@RouteID",rBody.RouteID),
                    new SqlParameter("@BookDate",rBody.BookingDate.ToDateTime(new TimeOnly(0, 0)))
                    };
                    using(SqlDataReader dr = SQLConnection.PrmRead("SELECT BookSeatNo FROM tbl_Booking where TraindID=@TraindID and RouteID=@RouteID and BookTime=@BookTime and BookDate=@BookDate", checkLocation))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                setList.Add(
                                    new TakedSeatList
                                    {
                                        BookSeatNo = Convert.ToInt32(dr["BookSeatNo"])
                                    });
                            }
                            return Ok(setList);
                        }
                        else
                        {
                            return BadRequest(new StatusMessage
                            {
                                SCode = 404,
                                SMessage = "No data to view"
                            });
                        }
                    }
                
                }
                catch (Exception ex)
                {
                    LogToText.ExceptionLog(ex);
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400, 
                        SMessage = "An error occurred while creating the train. Please check your input data."
                    });
                }
            }
        }
    }
    public class TakedSeatList
    {
        public int sCode { get; set; }
        public int BookSeatNo { get; set; }
    }
    public class CheckLocationRBody
    {
        public string Token { get; set; }
       public int TrainID { get; set; }
        public int RouteID { get; set; }
        public DateOnly BookingDate { get; set; }        
    }
}
