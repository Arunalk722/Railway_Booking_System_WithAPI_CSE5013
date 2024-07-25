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
        [Route("/CreateTrain")]
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
                            SCode = 412,
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

        [HttpPut]
        [Route("/UpdateTrain")]
        public IActionResult Update(MakeTrainList makeTrain)
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
                    new SqlParameter("@TrainId",makeTrain.TrainId),
                    new SqlParameter("@TrainName",makeTrain.TrainName),
                    new SqlParameter("@IsActive",makeTrain.IsActive),
                    new SqlParameter("@CreatedDate",DateTime.Now.ToString()),
                   };
                    string query = "update tbl_TrainList set TrainName=@TrainName,IsActive=@IsActive,CreatedDate=@CreatedDate where TrainId=@TrainId";
                    if (SQLConnection.PrmWrite(query, sqlParameters))
                    {
                        return Ok(new StatusMessage
                        {
                            SCode = 200,
                            SMessage = "Train Details Updated"
                        });
                    }
                    else
                    {
                        return BadRequest(new StatusMessage
                        {
                            SCode = 412, 
                            SMessage = "An internal error occurred while Updating the train. Please check your input data."
                        });
                    }
                }
                catch (Exception ex)
                {
                    LogToText.ExceptionLog(ex);
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400, 
                        SMessage = "An error occurred while Updating the train. Please check your input data."
                    });
                }
            }

        }

        [HttpGet]
        [Route("/ViewAllTrain")]
        public async Task<IActionResult> ViewAllTrain(string token)
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
                    new SqlParameter("@IsActive",true),
                  };
                    string SQLQuery = "SELECT * FROM tbl_TrainList where IsActive=@IsActive";
                    using (SqlDataReader dr = SQLConnection.PrmRead(SQLQuery, sqlParameters))
                    {
                        List<TrainList> trainList = new List<TrainList>();
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                trainList.Add(new TrainList
                                {
                                    SCode = 200,
                                    IsActive = Convert.ToBoolean(dr["IsActive"].ToString()),
                                    TrainId = Convert.ToInt32(dr["TrainId"].ToString()),
                                    TrainName = dr["TrainName"].ToString()
                                });
                            }
                            if (trainList.Count != 0)
                            {
                                return Ok(trainList);
                            }
                            else{
                                return BadRequest(new StatusMessage
                                {
                                    SCode = 404,
                                    SMessage = "No data to view"
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
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400, 
                        SMessage = "An error occurred while selecting the train. Please check your input data."
                    });
                }
            }
           
        }

        [HttpGet]
        [Route("/ViewOneTrain")]
        public async Task<IActionResult> ViewOneTrain(string token,int TrainId)
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
                    new SqlParameter("@TrainId",TrainId),
                  };
                    string SQLQuery = "SELECT * FROM tbl_TrainList where TrainId=@TrainId";
                    using (SqlDataReader dr = SQLConnection.PrmRead(SQLQuery, sqlParameters))
                    {
                       
                        if (dr.Read())
                        {
                            return Ok(new TrainList
                            {
                                SCode = 200,
                                IsActive = Convert.ToBoolean(dr["IsActive"].ToString()),
                                TrainId = Convert.ToInt32(dr["TrainId"].ToString()),
                                TrainName = dr["TrainName"].ToString()
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
                        SMessage = "An error occurred while selecting the train. Please check your input data."
                    });
                }
            }

        }

        [HttpDelete]
        [Route("/DeleteTrain")]
        public async Task<IActionResult> DeleteTrain(string token, int TrainId)
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
                    new SqlParameter("@TrainId",TrainId),
                   };
                    string query = "delete [tbl_TrainList] where TrainId=@TrainId";
                    if (SQLConnection.PrmWrite(query, sqlParameters))
                    {
                        return Ok(new StatusMessage
                        {
                            SCode = 200,
                            SMessage = "Train was deleted"
                        });
                    }
                    else
                    {
                        return BadRequest(new StatusMessage
                        {
                            SCode = 412, 
                            SMessage = "An internal error occurred while deleting the train. Please check your input data."
                        });
                    }
                }
                catch (Exception ex)
                {
                    LogToText.ExceptionLog(ex);
                    return BadRequest(new StatusMessage
                    {
                        SCode = 400, 
                        SMessage = "An error occurred while deleting the train. Please check your input data."
                    });
                }
            }

        }
    }
    public class MakeTrainList
    {
        public string Token { get; set; }
        public int TrainId { get; set; }
        public string TrainName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class TrainList
    {
        public int SCode { get; set; }
        public int TrainId { get; set; }
        public string TrainName { get; set; }
        public bool IsActive { get; set; } 
        
    }
}