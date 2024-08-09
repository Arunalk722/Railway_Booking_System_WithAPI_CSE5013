using Microsoft.AspNetCore.Mvc;
using SOC_Project.Class_files;
using SOC_Project.FunctionFiles;
using System.Data.SqlClient;

namespace SOC_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatListingController : Controller
    {
        [HttpGet]
        [Route("/GetBookedSeatNo")]
        public IActionResult GetBookedSeats(string token,int trainID,int routeID,string bookingDate)
        {
            if (!WebTokenValidate.ValidateToken(token))
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
                    new SqlParameter("@TraindID",trainID),
                    new SqlParameter("@RouteID",routeID),
                    new SqlParameter("@BookDate",bookingDate)
                    };
                    using(SqlDataReader dr = SQLConnection.PrmRead("SELECT BookSeatNo FROM tbl_Booking where TraindID=@TraindID and RouteID=@RouteID and BookDate=@BookDate", checkLocation))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                setList.Add(
                                    new TakedSeatList
                                    {
                                        sCode=200,
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
                        SMessage = "An error occurred while creating the booking.Please try again later."
                    });
                }
            }
        }
    }
  
}
