﻿using Microsoft.AspNetCore.Mvc;
using SOC_Project.FunctionFiles;
using System.Data.SqlClient;

namespace SOC_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainBookingController : Controller
    {
        [HttpPost]
        [Route("/MakeBooking")]
        public IActionResult Index(TraingBookingReqBody reqBody)
        {
            if (!WebTokenValidate.TokenValidateing(reqBody.Token))
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
                    new SqlParameter("@TraindID",reqBody.TrainID),
                    new SqlParameter("@RouteID",reqBody.RouteID),
                    new SqlParameter("@PassengerNIC",reqBody.NIC),                    
                    new SqlParameter("@BookDate",reqBody.BookDate.ToDateTime(new TimeOnly(0, 0))),
                    new SqlParameter("@PasengerName",reqBody.PasengerName),
                    new SqlParameter("@BookSeatNo",reqBody.BookSeatNo),
                     new SqlParameter("@EnterDate", DateTime.Now.ToString()),
                    new SqlParameter("@IsActive",true),
                    new SqlParameter("@IsTraveled",false),
                   };
                    string query = "INSERT INTO [dbo].[tbl_Booking] ([TraindID], [RouteID], [PassengerNIC], [BookDate], [PasengerName], [BookSeatNo], [EnterDate], [IsActive], [IsTraveled]) VALUES (@TraindID, @RouteID, @PassengerNIC, @BookDate, @PasengerName, @BookSeatNo, @EnterDate, @IsActive, @IsTraveled)";
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
                            SCode = 500,
                            SMessage = "An internal error occurred while creating the train. Please check your input data."
                        });
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

        [HttpGet]
        [Route("/GetListAllOfBooking")]
        public IActionResult GetListOfBooking(string token, bool isActive, bool isTraveled)
        {
            if (WebTokenValidate.TokenValidateing(token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                        new SqlParameter("@IsActive",isActive),
                         new SqlParameter("@IsTraveled",isTraveled)
                    };
                    string query = "SELECT * FROM tbl_Booking where IsTraveled=@IsTraveled and IsActive=@IsActive";
                    using (SqlDataReader dr = SQLConnection.PrmRead(query, sqlParameters))
                    {
                        List<TraingBookingList> dataSetList = new List<TraingBookingList>();
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                dataSetList.Add(new TraingBookingList
                                {
                                    SCode = 200,
                                    BookingID = Convert.ToInt32(dr["BookingID"].ToString()),
                                    TrainID = Convert.ToInt32(dr["TraindID"].ToString()),
                                    RouteID = Convert.ToInt32(dr["RouteID"].ToString()),
                                    NIC = dr["PassengerNIC"].ToString(),
                                    BookDate = DateOnly.FromDateTime((DateTime)dr["BookDate"]),
                                    PasengerName = dr["PasengerName"].ToString(),
                                    BookSeatNo = Convert.ToInt32(dr["BookSeatNo"].ToString()),

                                });
                            }
                            return Ok(dataSetList);
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
                        SMessage = "An error occurred while listing all of booking. Please check your input data."
                    });
                }
            }
            else
            {
                return Unauthorized(new StatusMessage
                {
                    SCode = 401,
                    SMessage = "unauthorized token"
                });
            }
        }

        [HttpGet]
        [Route("/GetListAllOfBookingByNic")]
        public IActionResult GetListOfBooking(string token, bool isActive, bool isTraveled, string nic)
        {
            if (WebTokenValidate.TokenValidateing(token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                        new SqlParameter("@IsActive",isActive),
                        new SqlParameter("@IsTraveled",isTraveled),
                        new SqlParameter("@PassengerNIC",nic)
                    };
                    string query = "SELECT * FROM tbl_Booking where IsTraveled=@IsTraveled and IsActive=@IsActive";
                    using (SqlDataReader dr = SQLConnection.PrmRead(query, sqlParameters))
                    {
                        List<TraingBookingList> dataSetList = new List<TraingBookingList>();
                        if (dr != null) {
                            while (dr.Read())
                            {
                                dataSetList.Add(new TraingBookingList
                                {
                                    SCode = 200,
                                    BookingID = Convert.ToInt32(dr["BookingID"].ToString()),
                                    TrainID = Convert.ToInt32(dr["TraindID"].ToString()),
                                    RouteID = Convert.ToInt32(dr["RouteID"].ToString()),
                                    NIC = dr["PassengerNIC"].ToString(),
                                    BookDate = DateOnly.FromDateTime((DateTime)dr["BookDate"]),
                                    PasengerName = dr["PasengerName"].ToString(),
                                    BookSeatNo = Convert.ToInt32(dr["BookSeatNo"].ToString()),

                                });
                            }
                        }

                        if (dataSetList.Count == 0)
                        {
                            dataSetList.Add(new TraingBookingList
                            {
                                SCode = 204,
                                BookingID = 0,
                                TrainID = 0,
                                RouteID = 0,
                                NIC = "NA",
                            });
                        }
                        return Ok(dataSetList);
                    }
                }
                catch (Exception ex)
                {
                    LogToText.ExceptionLog(ex);
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400,
                        SMessage = "An error occurred while listing all of booking. Please check your input data."
                    });
                }
            }
            else
            {
                return Unauthorized(new StatusMessage
                {
                    SCode = 401,
                    SMessage = "unauthorized token"
                });
            }
        }

        [HttpPost]
        [Route("/DisableBooking")]
        public IActionResult UpdateBooking(string token, int bookingId, string nic)
        {
            if (WebTokenValidate.TokenValidateing(token))
            {
                try
                {
                   
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                        new SqlParameter("@BookingID",bookingId),                       
                    };
                    string query = "SELECT * FROM tbl_Booking where BookingID=@BookingID";
                    using (SqlDataReader dr = SQLConnection.PrmRead(query, sqlParameters))
                    {
                        if (dr.Read())
                        {
                            if (dr["PassengerNIC"].ToString()== nic)
                            {
                                if (Convert.ToBoolean(dr["IsTraveled"]) == false)
                                {

                                    SqlParameter[] updateStatus = new SqlParameter[]
                                    {
                                        new SqlParameter("@BookingID",bookingId),
                                        new SqlParameter("@IsActive",false)
                                    };
                                    if(SQLConnection.PrmWrite("UPDATE tbl_Booking set IsActive=@IsActive where BookingID=@BookingID", updateStatus))
                                    {
                                        return Ok(new StatusMessage
                                        {
                                            SCode = 200,
                                            SMessage = $"booking {bookingId} status updated to disable"
                                        });
                                    }
                                    else
                                    {
                                        return Unauthorized(new StatusMessage
                                        {
                                            SCode = 404,
                                            SMessage = "booking status update failed"
                                        });
                                    }
                                }
                                else
                                {
                                    return Unauthorized(new StatusMessage
                                    {
                                        SCode = 404,
                                        SMessage = "Already traveled this booking. can't be cancel"
                                    });
                                }
                            }
                            else
                            {
                                return Unauthorized(new StatusMessage
                                {
                                    SCode = 404,
                                    SMessage = "Please verify NIC Number for cancel booking"
                                });
                            }
                        }
                        else
                        {
                            return Unauthorized(new StatusMessage
                            {
                                SCode = 404,
                                SMessage = "please check booking Id"
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
                        SMessage = "An error occurred while disable booking. Please check your input data."
                    });
                }
            }
            else
            {
                return Unauthorized(new StatusMessage
                {
                    SCode = 401,
                    SMessage = "unauthorized token"
                });
            }
        }

    }
    public class TraingBookingReqBody
    {
        public  string Token { get; set; }
        public  int TrainID { get; set; }
        public  int RouteID { get; set; }
        public  string NIC { get; set; }
        public string PasengerName {  get; set; }   
        public  DateOnly BookDate { get; set; }      
        public  int BookSeatNo { get; set; }
    }

    public class TraingBookingList
    {
        public int BookingID {  get; set; }
        public int SCode { get; set; }
        public int TrainID { get; set; }
        public int RouteID { get; set; }
        public string NIC { get; set; }
        public string PasengerName { get; set; }
        public DateOnly BookDate { get; set; }       
        public int BookSeatNo { get; set; }
    }
}
