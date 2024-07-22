using Microsoft.AspNetCore.Mvc;
using SOC_Project.FunctionFiles;
using System.Data.SqlClient;

namespace SOC_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : Controller
    {
        [HttpPost]
        [Route("/CreatePassenger")]
        public IActionResult CreatePassenger(PassengerListReqBody passengerListReqBody)
        {
            if (WebTokenValidate.TokenValidateing(passengerListReqBody.Token))
            {
                try
                {

                    int a = 1;
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                        new SqlParameter("@NIC", passengerListReqBody.NIC),
                        new SqlParameter("@FullName", passengerListReqBody.FullName),
                        new SqlParameter("@PhoneNo", passengerListReqBody.PhoneNo),
                        new SqlParameter("@EmailAddress", passengerListReqBody.EmailAddress),
                        new SqlParameter("@RouteCount", a)
                    };

                    string query = "INSERT INTO [dbo].[Tbl_PassengerList] ([NIC], [FullName], [PhoneNo], [EmailAddress], [RouteCount]) VALUES (@NIC, @FullName, @PhoneNo, @EmailAddress, @RouteCount)";

                    if (SQLConnection.PrmWrite(query, sqlParameters))
                    {
                        return Ok(new StatusMessage
                        {
                            SCode = 200,
                            SMessage = "Passenger inserted successfully"
                        });
                    }
                    else
                    {
                        return BadRequest(new StatusMessage
                        {
                            SCode = 500,
                            SMessage = "An internal error occurred while creating the new passenger. Please check your input data."
                        });
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400,
                        SMessage = $"An error occurred while creating the new passenger. Error: {ex.Message}"
                    });
                }
            }
            else
            {
                return Unauthorized(new StatusMessage
                {
                    SCode = 401,
                    SMessage = "Unauthorized token"
                });
            }
        }

        [HttpGet]
        [Route("/CheckExsistingPassengers")]
        public IActionResult CheckExsisitngPassenger(string token, string nic)
        {
            if (!WebTokenValidate.TokenValidateing(token))
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
                    new SqlParameter("@NIC",nic),
                  };
                    string SQLQuery = "SELECT * FROM Tbl_PassengerList where NIC=@NIC";
                    using (SqlDataReader dr = SQLConnection.PrmRead(SQLQuery, sqlParameters))
                    {

                        if (dr.Read())
                        {
                            return Ok(new ListOfPassengers
                            {
                                SCode = 200,
                                NIC = dr["NIC"].ToString(),
                                FullName = dr["FullName"].ToString(),
                                PhoneNo = dr["PhoneNo"].ToString(),
                                EmailAddress = dr["EmailAddress"].ToString(),
                                RouteCount = Convert.ToInt32(dr["RouteCount"].ToString()),
                                IsActive = Convert.ToBoolean(dr["IsActive"].ToString()),
                            });
                        }
                        else
                        {
                            return Ok(new ListOfPassengers
                            {
                                SCode = 204,
                                FullName = "NA",
                                PhoneNo = "NA",
                                EmailAddress = "NA",
                                RouteCount = 0,
                                IsActive = false
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
                        SMessage = "An error occurred while selecting the Passengers. Please check your input data."
                    });
                }
            }
        }

        [HttpGet]
        [Route("/ViewAllPassengersList")]
        public IActionResult ListAllPassengers(string token)
        {
            if (WebTokenValidate.TokenValidateing(token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                        new SqlParameter("@IsActive",true)
                    };
                    string query = "SELECT * FROM Tbl_PassengerList";
                    using (SqlDataReader dr = SQLConnection.PrmRead(query, sqlParameters))
                    {
                        List<ListOfPassengers> dataSetList = new List<ListOfPassengers>();
                        while (dr.Read())
                        {
                            dataSetList.Add(new ListOfPassengers
                            {
                                SCode = 200,
                                NIC = dr["NIC"].ToString(),
                                FullName = dr["FullName"].ToString(),
                                PhoneNo = dr["PhoneNo"].ToString(),
                                EmailAddress = dr["EmailAddress"].ToString(),
                                RouteCount = Convert.ToInt32(dr["RouteCount"].ToString()),
                                 IsActive= Convert.ToBoolean(dr["IsActive"].ToString()),
                            });
                        }
                        if (dataSetList.Count == 0)
                        {
                            dataSetList.Add(new ListOfPassengers
                            {
                                SCode = 204,
                                NIC="NA",
                                FullName = "NA",
                                PhoneNo = "NA",
                                EmailAddress = "NA",
                                RouteCount = 0,
                                IsActive = false,
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
                        SMessage = "An error occurred while listing all of passengers. Please check your input data."
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

        [HttpDelete]
        [Route("/DeletePasssenger")]
        public IActionResult DeletePassengers(string token,string nic)
        {

            if (WebTokenValidate.TokenValidateing(token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                    new SqlParameter("@NIC",nic),
                    };
                    string query = "DELETE [dbo].[Tbl_PassengerList] WHERE [NIC] = @NIC";

                    if (SQLConnection.PrmWrite(query, sqlParameters))
                    {
                        return Ok(new StatusMessage
                        {
                            SCode = 200,
                            SMessage = "Passenger was delete"
                        });
                    }
                    else
                    {
                        return BadRequest(new StatusMessage
                        {
                            SCode = 500,
                            SMessage = "An internal error occurred while delete the Passenger. Please check your input data."
                        });
                    }

                }
                catch (Exception ex)
                {
                    LogToText.ExceptionLog(ex);
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400,
                        SMessage = "An error occurred while delete the Passenger. Please check your input data."
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

        [HttpPut]
        [Route("/UpdatePasssengerCount")]
        public IActionResult UpdatePasssenger(string token, string nic,int count)
        {
            if (WebTokenValidate.TokenValidateing(token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                    new SqlParameter("@NIC",nic),
                    new SqlParameter("@RouteCount",count),
                    
                    };
                    string query = "UPDATE [dbo].[Tbl_PassengerList] SET [RouteCount] = @RouteCount WHERE [NIC] = @NIC";

                    if (SQLConnection.PrmWrite(query, sqlParameters))
                    {
                        return Ok(new StatusMessage
                        {
                            SCode = 200,
                            SMessage = "Passenger Rout Count updated"
                        });
                    }
                    else
                    {
                        return BadRequest(new StatusMessage
                        {
                            SCode = 500,
                            SMessage = "An internal error occurred while updating the Passenger. Please check your input data."
                        });
                    }

                }
                catch (Exception ex)
                {
                    LogToText.ExceptionLog(ex);
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400,
                        SMessage = "An error occurred while updating the Passenger. Please check your input data."
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
    public class PassengerListReqBody
    {
        public string Token { get; set; }
        public string NIC { get; set; }
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }

    }

    public class ListOfPassengers
    {
        public int SCode { get; set; }
        public string NIC { get; set; }
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }
        public int RouteCount { get; set; }
       required public bool IsActive { get; set; }

    }
}
