using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace SOC_Project.FunctionFiles
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthenticationController : Controller
    {

        [HttpPost]
        [Route("/UserAuthLogin")]
        public IActionResult Login(UserAuth userAuthRequest)
        {
            if (WebTokenValidate.ValidateToken(userAuthRequest.Token))
            {
                try
                {
                    SqlParameter[] sqlParameters = new SqlParameter[]
                    {
                    new SqlParameter("@UserName",userAuthRequest.UserName),
                    new SqlParameter("@Pwd",userAuthRequest.Pwd),
                  
                    };
                    using(SqlDataReader dr = SQLConnection.PrmRead("SELECT ul.UserID,ul.UserName,ul.Email,ul.UserRole, ur.UserRoleName FROM tbl_UserList AS ul JOIN tbl_UserRoles AS ur ON ul.UserRole = ur.UserRolesId where ul.UserName=@UserName and ul.Pwd=@Pwd;", sqlParameters))
                    {
                        if (dr != null)
                        {
                            if (dr.Read()) { 
                                return Ok(new UserCredentinals
                                {
                                    SCode=200,
                                    Email = dr["Email"].ToString(),
                                    UserId = Convert.ToInt32(dr["UserID"]),
                                    UserName= dr["UserName"].ToString(),
                                    UserRole = dr["UserRoleName"].ToString(),
                                    UserRoleID = Convert.ToInt32(dr["UserRole"].ToString())

                                });
                            }
                            else
                            {
                                return BadRequest(
                                new StatusMessage
                                {
                                    SCode = 500,
                                    SMessage = "Login Invalid"
                                }
                            );

                            }
                        }
                        else
                        {
                            return BadRequest(
                                new StatusMessage
                                {
                                    SCode=403,
                                    SMessage="Login Invalid"
                                }
                            );
                        }
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
    }


    public class UserAuth
    {
        required public string Token { get; set; }
        required public string UserName { get; set; }
        required public string Pwd { get; set; }
    }
    public class UserCredentinals {
        public int SCode { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email {  get; set; }
        public string UserRole {  get; set; }
        public int UserRoleID {  get; set; }

    }

}
