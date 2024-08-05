using Microsoft.AspNetCore.Mvc;
using SOC_Project.FunctionFiles;
using System.Data.SqlClient;
using System.Collections.Generic;
using SOC_Project.Class_files;

namespace SOC_Project.Controllers
{
    public class DetailsBookingReportController : Controller
    {
        [HttpGet]
        [Route("GetListOfBooking")]
        public IActionResult GetListOfBooking(string token/*, int? bookingID = null, string nic = null*/)
        {
            if (!WebTokenValidate.ValidateToken(token))
            {
                return Unauthorized(new { SCode = 401, SMessage = "Unauthorized token" });
            }
            else
            {
                try
                {
                    string SQLQuery = @"
        SELECT 
            bk.BookingID,
            bk.TraindID,
            bk.RouteID,
            bk.PassengerNIC,
            bk.PasengerName,
            pl.PhoneNo,
            pl.EmailAddress,        
            pl.FullName,
            bk.BookDate,
            bk.BookSeatNo,
            tl.TrainName,
            tr.SourLocation,
            tr.DestLocation,
            tr.SchaduleTime,
            bk.EnterDate as BookRecordTime,
            bk.IsActive AS BookingIsActive,
            bk.IsTraveled,
            pl.IsActive AS PassengerIsActive,   
            tl.IsActive AS TrainIsActive,
            tl.CreatedDate AS TrainCreatedDate,   
            ul.UserName as TrainCreatedUser,
            tr.CreatedDate AS RouteCreatedDate,
            tr.IsActive AS RouteIsActive
        FROM 
            tbl_Booking AS bk
        JOIN 
            Tbl_PassengerList AS pl ON bk.PassengerNIC = pl.NIC
        JOIN 
            tbl_TrainList AS tl ON bk.TraindID = tl.TrainId
        JOIN 
            tbl_TrainRoute AS tr ON bk.RouteID = tr.RouteId
        JOIN 
            tbl_UserList AS ul ON ul.UserID = tr.CreatedUser"; 
                    
                    
                   

                    List<SqlParameter> sqlParameters = new List<SqlParameter>();
                    { 

                    sqlParameters.Add(new SqlParameter("@PassengerNIC", DBNull.Value));
                    }

                    List<BookingDetails> bookingDetailsList = new List<BookingDetails>();

                    using (SqlDataReader reader = SQLConnection.PrmRead(SQLQuery, sqlParameters.ToArray())) 
                    { 
                        
                        if(reader !=null)
                        {
                            while (reader.Read())
                            {
                                BookingDetails details = new BookingDetails
                                {
                                    BookingID = Convert.ToInt32(reader["BookingID"]),
                                    TraindID = Convert.ToInt32(reader["TraindID"]),
                                    RouteID = Convert.ToInt32(reader["RouteID"]),
                                    PassengerNIC = reader["PassengerNIC"].ToString(),
                                    PasengerName = reader["PasengerName"].ToString(),
                                    PhoneNo = reader["PhoneNo"].ToString(),
                                    EmailAddress = reader["EmailAddress"].ToString(),                                    
                                    FullName = reader["FullName"].ToString(),
                                    BookDate = Convert.ToDateTime(reader["BookDate"]),
                                    BookSeatNo = Convert.ToInt32(reader["BookSeatNo"]),
                                    TrainName = reader["TrainName"].ToString(),
                                    SourLocation = reader["SourLocation"].ToString(),
                                    DestLocation = reader["DestLocation"].ToString(),
                                    SchaduleTime = (TimeSpan)reader["SchaduleTime"],
                                    BookRecordTime = Convert.ToDateTime(reader["BookRecordTime"]),
                                    BookingIsActive = Convert.ToBoolean(reader["BookingIsActive"]),
                                    IsTraveled = Convert.ToBoolean(reader["IsTraveled"]),
                                    PassengerIsActive = Convert.ToBoolean(reader["PassengerIsActive"]),
                                    TrainIsActive = Convert.ToBoolean(reader["TrainIsActive"]),
                                    TrainCreatedDate = Convert.ToDateTime(reader["TrainCreatedDate"]),
                                    TrainCreatedUser = reader["TrainCreatedUser"].ToString(),
                                    RouteCreatedDate = Convert.ToDateTime(reader["RouteCreatedDate"]),
                                    RouteIsActive = Convert.ToBoolean(reader["RouteIsActive"])
                                };
                                bookingDetailsList.Add(details);
                            }
                            reader.Close();
                           
                            if(bookingDetailsList.Count > 0)
                            {
                                return Ok(bookingDetailsList);
                            }
                            else
                            {
                                 return BadRequest(new StatusMessage
                            {
                                SCode=404,
                                SMessage="No data to view"
                            });
                            }
                        }
                        else
                        {
                            return BadRequest(new StatusMessage
                            {
                                SCode = 502,
                                SMessage = "No data to view"
                            });
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
