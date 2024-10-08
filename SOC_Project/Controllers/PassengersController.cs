﻿using Microsoft.AspNetCore.Mvc;
using SOC_Project.Class_files;
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
            if (WebTokenValidate.ValidateToken(passengerListReqBody.Token))
            {
                try
                {
                   
                    SqlParameter[] checkNIC = new SqlParameter[]
                    {
                           new SqlParameter("@NIC", passengerListReqBody.NIC),
                    };

                    using (SqlDataReader dr = SQLConnection.PrmRead("SELECT NIC FROM Tbl_PassengerList where NIC=@NIC", checkNIC))
                    {
                        if (!dr.Read()) {
                            int a = 1;
                            SqlParameter[] sqlParameters = new SqlParameter[]
                               {
                        new SqlParameter("@NIC", passengerListReqBody.NIC),
                        new SqlParameter("@FullName", passengerListReqBody.FullName),
                        new SqlParameter("@PhoneNo", passengerListReqBody.PhoneNo),
                        new SqlParameter("@EmailAddress", passengerListReqBody.EmailAddress),
                        new SqlParameter("@RouteCount", a),
                        new SqlParameter("@IsActive",true)
                             };
                            string query = "INSERT INTO [dbo].[Tbl_PassengerList] ([NIC], [FullName], [PhoneNo], [EmailAddress], [RouteCount],[IsActive]) VALUES (@NIC, @FullName, @PhoneNo, @EmailAddress, @RouteCount,@IsActive)";
                            if (SQLConnection.ExecuteWriteCommand(query, sqlParameters))
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
                                    SCode = 412,
                                    SMessage = "An internal error occurred while creating the new passenger. Please check your input data."
                                });
                            }
                        }
                        else
                        {
                            return Ok(new StatusMessage
                            {
                                SCode = 404,
                                SMessage = "Your already registed in the system"
                            });
                        }
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
                    SqlParameter[] sqlParameters = new SqlParameter[]
                  {
                    new SqlParameter("@NIC",nic),
                  };
                    string sqlQuery = "SELECT * FROM Tbl_PassengerList where NIC=@NIC";
                    using (SqlDataReader dr = SQLConnection.PrmRead(sqlQuery, sqlParameters))
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
                        SMessage = "An error occurred while selecting the Passengers. Please check your input data."
                    });
                }
            }
        }

        [HttpGet]
        [Route("/ViewAllPassengersList")]
        public IActionResult ListAllPassengers(string token)
        {
            if (WebTokenValidate.ValidateToken(token))
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
                        if (dr != null)
                        {
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
                                    IsActive = Convert.ToBoolean(dr["IsActive"].ToString()),
                                });
                            }
                        }

                        if (dataSetList.Count != 0)
                        {
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

            if (WebTokenValidate.ValidateToken(token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                    new SqlParameter("@NIC",nic),
                    };
                    string query = "DELETE [dbo].[Tbl_PassengerList] WHERE [NIC] = @NIC";

                    if (SQLConnection.ExecuteWriteCommand(query, sqlParameters))
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
                            SCode = 412,
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
            if (WebTokenValidate.ValidateToken(token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                    new SqlParameter("@NIC",nic),
                    new SqlParameter("@RouteCount",count),
                    
                    };
                    string query = "UPDATE [dbo].[Tbl_PassengerList] SET [RouteCount] = @RouteCount WHERE [NIC] = @NIC";

                    if (SQLConnection.ExecuteWriteCommand(query, sqlParameters))
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
                            SCode = 412,
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
   
}
