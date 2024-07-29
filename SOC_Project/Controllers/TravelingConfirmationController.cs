using Microsoft.AspNetCore.Mvc;
using SOC_Project.FunctionFiles;
using System.Data.SqlClient;

namespace SOC_Project.Controllers
{
    public class TravelingConfirmationController : Controller
    {
        [HttpGet]
        [Route("/BookingConfirm")]
        public IActionResult BookingConfirm(string token, string bookingID)
        {
            if (!WebTokenValidate.TokenValidateing(token))
            {
                return Unauthorized(new { SCode = 401, SMessage = "Unauthorized token" });
            }
            else
            {
                try
                {
                    SqlParameter[] checkStatus = new SqlParameter[] {
                        new SqlParameter("@BookingID",bookingID)
                    };
                    using (SqlDataReader dr = SQLConnection.PrmRead("SELECT IsActive,IsTraveled from tbl_Booking where BookingID=@BookingID", checkStatus))
                    {
                        if (dr!=null&&dr.Read())
                        {
                            if (Convert.ToBoolean(dr["IsActive"]) == true)
                            {
                                if (Convert.ToBoolean(dr["IsTraveled"]) == false)
                                {
                                    SqlParameter[] confTravel = new SqlParameter[] {
                                        new SqlParameter("@BookingID",bookingID)
                                    };
                                    if (SQLConnection.PrmWrite("UPDATE tbl_Booking set IsTraveled='true' where BookingID=@BookingID and IsActive='true'", confTravel))
                                    {
                                        return Ok(new { SCode = 200, SMessage = "Best wishes on your journey.your successful completed booking" });
                                    }
                                    else
                                    {
                                        return BadRequest(new { SCode = 412, SMessage = "Error to updating booking." });
                                    }
                                }
                                else
                                {
                                    return BadRequest(new { SCode = 404, SMessage = $"Booking is already traveled & closed.this booking not valid booking ID {bookingID}" });

                                }
                            }
                            else
                            {
                                return BadRequest(new { SCode = 404, SMessage = "booking was disabled.please race new booking" });
                               
                            }
                        }
                        else
                        {
                            return BadRequest(new { SCode = 502, SMessage = $"Please check booking id {bookingID}" });
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogToText.ExceptionLog(ex);
                    return BadRequest(new { SCode = 400, SMessage = "An error occurred while listing all of the bookings. Please check your input data." });
                }
            }
        }
    }
}
