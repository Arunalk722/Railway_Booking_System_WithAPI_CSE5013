using Microsoft.AspNetCore.Mvc;
using SOC_Project.Class_files;
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
        [Route("/CreateRoute")]
        public IActionResult CreateTrainRoute(TrainRoute routeData)
        {
            if (WebTokenValidate.ValidateToken(routeData.Token))
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
                    if (SQLConnection.ExecuteWriteCommand(query, sqlParameters))
                    {
                        return Ok(new StatusMessage
                        {
                            SCode = 200,
                            SMessage = "Train route Insert"
                        });
                    }
                    else
                    {
                        return BadRequest(new StatusMessage
                        {
                            SCode = 412,
                            SMessage = "An internal error occurred while creating the train route. Please check your input data."
                        });
                    }

                }
                catch (Exception ex)
                {
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400,
                        SMessage = "An error occurred while creating the train route. Please check your input data."
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
        [Route("/UpdateRoute")]
        public IActionResult UpdateTrainRoute(TrainRoute routeData,int routeId)
        {
            if (WebTokenValidate.ValidateToken(routeData.Token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                    new SqlParameter("@RouteId",routeId),
                    new SqlParameter("@TrainID",routeData.TrainId),
                    new SqlParameter("@SourLocation",routeData.SourLocatin),
                    new SqlParameter("@DestLocation",routeData.DestLocation),
                    new SqlParameter("@SchaduleTime",routeData.SchaduleTime),
                    new SqlParameter("@CreatedUser",routeData.CreatedUser),
                    new SqlParameter("@CreatedDate",DateTime.Now.ToString()),
                    new SqlParameter("@IsActive",routeData.IsActive)
                    };
                    string query = "UPDATE [dbo].[tbl_TrainRoute] SET [TrainID] = @TrainID, [SourLocation] = @SourLocation, [DestLocation] = @DestLocation, [SchaduleTime] = @SchaduleTime, [CreatedUser] = @CreatedUser, [CreatedDate] = @CreatedDate, [IsActive] = @IsActive WHERE [RouteId] = @RouteId";

                    if (SQLConnection.ExecuteWriteCommand(query, sqlParameters))
                    {
                        return Ok(new StatusMessage
                        {
                            SCode = 200,
                            SMessage = "Train route updated"
                        });
                    }
                    else
                    {
                        return BadRequest(new StatusMessage
                        {
                            SCode = 412,
                            SMessage = "An internal error occurred while updating the train route. Please check your input data."
                        });
                    }

                }
                catch (Exception ex)
                {
                    LogToText.ExceptionLog(ex);
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400,
                        SMessage = "An error occurred while updating the train route. Please check your input data."
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
        [Route("/DeleteRoute")]
        public IActionResult DeleteRoute(string token, int RouteId)
        {

            if (WebTokenValidate.ValidateToken(token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                    new SqlParameter("@RouteId",RouteId),                   
                    };
                    string query = "DELETE [dbo].[tbl_TrainRoute] WHERE [RouteId] = @RouteId";

                    if (SQLConnection.ExecuteWriteCommand(query, sqlParameters))
                    {
                        return Ok(new StatusMessage
                        {
                            SCode = 200,
                            SMessage = "Train route was delete"
                        });
                    }
                    else
                    {
                        return BadRequest(new StatusMessage
                        {
                            SCode = 412,
                            SMessage = "An internal error occurred while delete the train route. Please check your input data."
                        });
                    }

                }
                catch (Exception ex)
                {
                    LogToText.ExceptionLog(ex);
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400,
                        SMessage = "An error occurred while delete the train route. Please check your input data."
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
        [Route("/ViewAllRoute")]
        public IActionResult ViewAllRoute(string Token)
        {
            if (WebTokenValidate.ValidateToken(Token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                  new SqlParameter("@IsActive",true)
                    };
                    string query = "SELECT tr.*,tl.TrainName,ul.UserName FROM tbl_TrainRoute as tr join tbl_UserList as ul on ul.UserID=tr.CreatedUser join tbl_TrainList as tl on tl.TrainId=tr.TrainID";
                    using (SqlDataReader dr = SQLConnection.PrmRead(query, sqlParameters))
                    {
                        List<ListOfRoutes> listOfRoutes = new List<ListOfRoutes>();
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                listOfRoutes.Add(new ListOfRoutes
                                {
                                    SCode = 200,
                                    RouteId = Convert.ToInt32(dr["RouteId"]),
                                    TrainID = Convert.ToInt32(dr["TrainID"]),
                                    SourLocation = dr["SourLocation"].ToString(),
                                    DestLocation = dr["DestLocation"].ToString(),
                                    SchaduleTime = dr["SchaduleTime"].ToString(),
                                    UserName = dr["UserName"].ToString(),
                                    IsActive = Convert.ToBoolean(dr["IsActive"].ToString()),
                                    TrainName = dr["TrainName"].ToString(),

                                });
                            }
                        }
                        if (listOfRoutes.Count != 0)
                        {
                            return Ok(listOfRoutes);
                            
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
                        SMessage = "An error occurred while viewing the train route. Please check your input data."
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
        [Route("/ViewOneRoute")]
        public IActionResult ViewOneRoute(string Token, string routeID)
        {
            if (WebTokenValidate.ValidateToken(Token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                  new SqlParameter("@RouteId",routeID)
                    };
                    string query = "SELECT tr.*,tl.TrainName,ul.UserName FROM tbl_TrainRoute as tr join tbl_UserList as ul on ul.UserID=tr.CreatedUser join tbl_TrainList as tl on tl.TrainId=tr.TrainID";
                    using (SqlDataReader dr = SQLConnection.PrmRead(query, sqlParameters))
                    {
                        if (dr.Read())
                        {
                            return Ok(new ListOfRoutes
                            {
                                SCode = 200,
                                RouteId = Convert.ToInt32(dr["RouteId"]),
                                TrainID = Convert.ToInt32(dr["TrainID"]),
                                SourLocation = dr["SourLocation"].ToString(),
                                DestLocation = dr["DestLocation"].ToString(),
                                SchaduleTime = dr["SchaduleTime"].ToString(),
                                UserName = dr["UserName"].ToString(),
                                IsActive = Convert.ToBoolean(dr["IsActive"].ToString()),
                                TrainName= dr["TrainName"].ToString(),
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
                        SMessage = "An error occurred while viewing individual the train route. Please check your input data."
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
