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
        [Route("/CreateRoute")]
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
                    if (SQLConnection.PrmWrite(query, sqlParameters))
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
                            SCode = 500,
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

        [HttpPost]
        [Route("/Update")]
        public IActionResult UpdateTrainRoute(TrainRoute routeData)
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
                    string query = "UPDATE [dbo].[tbl_TrainRoute] SET [TrainID] = @TrainID, [SourLocation] = @SourLocation, [DestLocation] = @DestLocation, [SchaduleTime] = @SchaduleTime, [CreatedUser] = @CreatedUser, [CreatedDate] = @CreatedDate, [IsActive] = @IsActive WHERE [RouteId] = @RouteId";

                    if (SQLConnection.PrmWrite(query, sqlParameters))
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
                            SCode = 500,
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
        [Route("/Delete")]
        public IActionResult DeleteRoute(string token, string routeId)
        {

            if (WebTokenValidate.TokenValidateing(token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                    new SqlParameter("@TrainID",routeId),                   
                    };
                    string query = "DELETE [dbo].[tbl_TrainRoute] WHERE [RouteId] = @RouteId";

                    if (SQLConnection.PrmWrite(query, sqlParameters))
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
                            SCode = 500,
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
            if (WebTokenValidate.TokenValidateing(Token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                  new SqlParameter("@IsActive",true)
                    };
                    string query = "SELECT * FROM tbl_TrainRoute where IsActive=@IsActive";
                    using (SqlDataReader dr = SQLConnection.PrmRead(query, sqlParameters))
                    {
                        List<ListOfRoutes> listOfRoutes = new List<ListOfRoutes>();
                        while (dr.Read())
                        {
                            listOfRoutes.Add(new ListOfRoutes
                            {
                                SCode = 200,
                                RouteId = Convert.ToInt32(dr["RouteId"]),
                                TrainID = Convert.ToInt32(dr["TrainID"]),
                                SourLocation = dr["SourLocation"].ToString(),
                                DestLocation = dr["DestLocation"].ToString(),
                                SchaduleTime = dr["SchaduleTime"].ToString()
                            });
                        }
                        if (listOfRoutes.Count == 0)
                        {
                            listOfRoutes.Add(new ListOfRoutes
                            {
                                SCode = 204,
                                RouteId = 0,
                                TrainID = 0,
                                SourLocation = "NA",
                                DestLocation = "NA",
                                SchaduleTime = "NA"
                            });
                        }
                        return Ok(listOfRoutes);
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
            if (WebTokenValidate.TokenValidateing(Token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                  new SqlParameter("@RouteId",routeID)
                    };
                    string query = "SELECT * FROM tbl_TrainRoute where RouteId=@RouteId";
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
                                SchaduleTime = dr["SchaduleTime"].ToString()
                            });
                        }
                        else
                        {
                            return Ok(new ListOfRoutes
                            {
                                SCode = 204,
                                RouteId = 0,
                                TrainID = 0,
                                SourLocation = "NA",
                                DestLocation = "NA",
                                SchaduleTime = "NA"
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
    public class TrainRoute
    {
        public string Token { get; set; }
        public int TrainId { get; set; }
        public string SourLocatin { get; set; }
        public string DestLocation { get; set; }
        public DateTime SchaduleTime { get; set; }
        public int CreatedUser { get; set; }
        public bool IsActive { get; set; }
    }

    public class ListOfRoutes
    {
        public int SCode { get; set; }
        public int RouteId { get; set; }
        public int TrainID { get; set; }
        public string SourLocation { get; set; }
        public string DestLocation { get; set; }
        public string SchaduleTime { get; set; }
    }
}
